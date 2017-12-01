using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyStore;
using ConsignatieMagazinBiblioteca;

namespace ConsignatieUI
{
    public partial class Consignatie : Form
    {
        private ConsignatieMagazinBiblioteca.Depozit depozit =
            new ConsignatieMagazinBiblioteca.Depozit();
        private List<ConsignatieMagazinBiblioteca.Item> shoppingCartData 
            = new List<ConsignatieMagazinBiblioteca.Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource furnizoriBinding = new BindingSource();
        private decimal storeProfit = 0;

        public Consignatie()
        {
            InitializeComponent();
            IntroducereData();

            itemsBinding.DataSource = depozit.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;
            itemsListbox.DisplayMember = "toString";
            itemsListbox.ValueMember = "toString";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;
            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            furnizoriBinding.DataSource = depozit.Furnizori;
            FurnizoriListbox.DataSource = furnizoriBinding;
            FurnizoriListbox.DisplayMember = "toString";
            FurnizoriListbox.ValueMember = "toString";

        }

        private void IntroducereData()
        {
            //depozit.Furnizori = new System.Collections.Generic.List<ConsignatieMagazinBiblioteca.Furnizor>();

            depozit.Furnizori.Add(new ConsignatieMagazinBiblioteca.Furnizor
            { Nume = "TORJE", Prenume = "David", });
            var furnizor1 = EntityStore.instance.CreateFurnizor("TORJE", "Timotei");
            depozit.Furnizori.Add(furnizor1);
            depozit.Furnizori.Add(EntityStore.instance.CreateFurnizorWithPersonalComision(
                "TORJE", "Ioan", .7));
            
            depozit.Items.Add(EntityStore.instance.CreateItem("Moby Dick", "A book about a whale",
                4.50M, 20, false, depozit.Furnizori[0]));
            depozit.Items.Add(new ConsignatieMagazinBiblioteca.Item
            {
                Title = "A Tale of Two Cities",
                Descriere = "A book about a revolution",
                Pret = 3.80M,
                NumberOfItems = 10,
                Owner = depozit.Furnizori[1]
            });
            depozit.Items.Add(new ConsignatieMagazinBiblioteca.Item
            {
                Title = "Harry Potter Book 1",
                Descriere = "A book about a boy",
                Pret = 5.20M,
                Owner = depozit.Furnizori[1]
            });
            depozit.Items.Add(new ConsignatieMagazinBiblioteca.Item
            {
                Title = "Jane Eyre",
                Descriere = "A book about a girl",
                Pret = 1.50M,
                NumberOfItems = 7,
                Owner = depozit.Furnizori[0]
            });
            depozit.Items.Add(EntityStore.instance.CreateItem("Robin Hood", "A book about a outlaw",
                3.77M, 17, false, depozit.Furnizori[2]));

            depozit.Nume = "MoreThanBooks";

        }

        private void purchaseItem_Click(object sender, System.EventArgs e)
        {
            ConsignatieMagazinBiblioteca.Item selectedItem 
                            = (ConsignatieMagazinBiblioteca.Item)itemsListbox.SelectedItem;

            if (selectedItem.NumberOfItems < 1)
            {
                MessageBox.Show("Stoc epuizat pentru produsul " + selectedItem.Title, "Stoc epuizat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                selectedItem.NumberOfItems = selectedItem.NumberOfItems - 1;
                if (selectedItem.Duplicate.Equals(false))
                {
                    shoppingCartData.Add(selectedItem);
                }
                selectedItem.Duplicate = true;
                selectedItem.SoldItems += 1;
            }
            
            itemsBinding.ResetBindings(false);

            cartBinding.ResetBindings(false);

        }

        private void makePurchase_Click(object sender, System.EventArgs e)
        {
            foreach(ConsignatieMagazinBiblioteca.Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Duplicate = false;
                item.Owner.PaymentDue += CalculProfitOwner(item);
                storeProfit += CalculProfitDepozit(item);
                item.SoldItems = 0;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = depozit.Items.Where(x => x.NumberOfItems > 0).ToList();

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            furnizoriBinding.ResetBindings(false);
        }

        public decimal CalculProfitOwner(Item item)
        {
            return ((decimal)item.Owner.Comision * item.Pret * item.SoldItems);
        }

        public decimal CalculProfitDepozit(Item item)
        {
            return ((1 - (decimal)item.Owner.Comision) * item.Pret * item.SoldItems);
        }
    }
}
