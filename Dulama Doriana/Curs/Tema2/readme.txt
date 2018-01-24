	Datele pacientilor si datele pentru adeverinta/reteta sunt hardcodate.
	Intr-o aplicatie reala toate aceste date ar fi adaugate de user.
	Atat template-urile cat si documentele generate se salveaza in Tema2/bin/Debug.

	Aplicatia modeleaza domeniul unui cabinet al doctorului de familie, pentru a simplifica munca acestuia.
	Fiecare pacient va avea fisa sa cu date personale sau cu istoric, generate intr-un pdf,
medicul accesandu-le pe baza cnp-ului pacientului. Astfel, la alegere, medicul poate vizualiza
fisa de date personale ale pacientului, sau fisa cu istoricul acestuia. Fisa de date personale se va
completa in functie de datele introduse de medic (in aplicatie sunt hardcodate), iar fisa de istoric 
se completeaza pe parcursul vizitelor acestuia la medic, in momentul in care primeste o adeverinta
pentru o anumita afectiune. 
	Sistemul va genera totodata la alegere intr-un document, adeverinta medicala sau reteta, in functie
de necesitatile pacientului. Medicul trebuie sa introduca doar cnp-ul pacientului (pacientul trebuie sa fie inregistrat
la medicul respectiv), dupa care sa aleaga tipul de document dorit, generandu-se ulterior fisa necesara,gata de imprimat.
Intr-o aplicatie reala, medicul va da datele despre afectiune, recomandare sau pastile de cumparat 
de la tastatura, insa in aplicatia curenta, datele sunt hardcodate pentru o verificare a functionalitatii
mai usoara.
	