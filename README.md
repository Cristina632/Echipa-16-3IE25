# Echipa-16-3IE25

📦 Sistem de Gestiune și Analiză Stocuri
O aplicație desktop dezvoltată în C# (Windows Forms) care gestionează evidența produselor și oferă statistici vizuale privind performanța comercială (vânzări vs. achiziții).

🚀 Funcționalități Principale
Dashboard Central: Meniu principal pentru navigare rapidă între module.

Gestiune Produse (CRUD):

Interfață pentru vizualizarea și modificarea bazei de date cu produse.

Editare directă a detaliilor (ID, Denumire, UM, Stoc siguranță, Preț).

Salvarea modificărilor în baza de date folosind TableAdapters.

Analiză și Raportare:

Interogări SQL complexe (folosind GROUP BY și SUM) pentru a calcula totalul cantităților vândute și achiziționate.

Vizualizare Grafică: Generare dinamică a unui grafic (Chart Control) care compară "Achizițiile" cu "Vânzările" pentru fiecare produs.

Tabel de sinteză cu date agregate.

🛠️ Tehnologii Utilizate
Limbaj: C# (.NET Framework 4.7.2)

GUI: Windows Forms (WinForms)

Bază de date: Microsoft Access (.accdb)

Acces Date:

ADO.NET (OleDbConnection, OleDbDataAdapter) pentru rapoarte.

Typed DataSets pentru formularul de editare.

Componente: System.Windows.Forms.DataVisualization.Charting pentru grafice.

⚙️ Cum funcționează
Form1 (Main): Lansează aplicația.

Form2 (Gestiune): Se conectează la tabelele Iesiri și Produse pentru a permite modificarea datelor.

Form3 (Statistici): Execută o interogare SQL care unește tabelele produse, intrari și iesiri pentru a genera graficul comparativ.

# Membrii echipei: Alexandru Pop, Emanuel Moisa, Cristina Moraru, Patricia Popeti.

modificat de Emanuel Moisa
modificat Patricia Popeti
modificat Pop Alexandru

# modificat în VScode - Moraru Cristina
=======
modificat  în VScode - Popeti Patricia
>>>>>>> b0e3c0892fd3a62627de829c97b0456978c5a78b
=======
modificat în VScode - Emanuel Moisa
>>>>>>> 180b49130f688ea51a789d5e0d2cc46f05a1ca02

# modificat in VScode - Pop Alexandru
