using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC
{
    public class Functions
    {
        public Functions(Restaurant restaurant, int sw)
        {
            switch (sw)
            {
                case 1:
                    clear_controls(restaurant);
                    break;
                case 2:
                    clear_controls(restaurant);
                    reset_orders();
                    break;
                default:
                    break;
            }
        
        }

        public static void clear_controls(Restaurant restaurant)
        {

                        //Restaurant restaurant = new Restaurant();
                        restaurant.dgv_drinks.Rows.Clear();
                        restaurant.dgv_food.Rows.Clear();
                        restaurant.cmb_drinks.SelectedIndex = -1;
                        restaurant.cmb_food.SelectedIndex = -1;
                        restaurant.cmb_table.SelectedIndex = -1;
                        restaurant.cmb_waiter.SelectedIndex = -1;
                        restaurant.cmb_drinks.Text = string.Empty;
                        restaurant.cmb_food.Text = string.Empty;
                        restaurant.cmb_table.Text = string.Empty;
                        restaurant.cmb_waiter.Text = string.Empty;
                        restaurant.txt_x_drinks.Text = "1";
                        restaurant.txt_x_food.Text = "1";          
        }

        public static void reset_orders()
        {
            MyLists._my_drinks_list.Clear();
            MyLists._my_food_list.Clear();
            MyLists._my_orders_list.Clear();
            Variables._order_nr = 0;
        }
    }
}
