# ElektrikuluKalkulaator

**Lühikirjeldus**

See on lihtne väike projekt, mille abil saab arvutada elektriseadme elektrikulu 30 päeva jooksul ning palju see maksma läheb.
Arvutused ja Errorite kontrollid on kõik Library failis.

Kõik sisendid peab sisestama kasutaja ning programm siis nende põhjal arvutab kulu ning hinna.

**Käivitamine**
1. Ava Visual Studio
2. Veendu, et teil oleks .NET 10 versioon.
3. Veendu, et Elektrikulu.WPFappil oleks viide Librarisse ning, oleks startup project.
4. Käivita WPF app
5. sisesta andmed ning vajuta "Arvuta"

**Sisendite Kontroll**

Äpp kontrollib järgnevat:
- Et Kulu > 0
- Töötunnid oleks vahemikus 0-24
- hind > 0
- sisend peab olema Number

**Kontrollnäited**

tavapärane sisend:

Võimsus: 1500W
Tunnid Päevas: 2
Hind: 0.20

Oodatud tulemus:
Kulu 30 päeva jooksul: 18.00 €

----------------------------------------

Vigane sisend:

Kulu: -500
Tunnidpäevas: 5
Hind: 0.20

Oodatud tulemus:
Kulu peab olema suurem, kui 0W.
