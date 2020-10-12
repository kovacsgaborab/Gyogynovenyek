

# Megoldás:

## Osztály létrehozása
- Kétféle mód közül bármelyik: 
  - Ctrl + .
  - Adjunk hozzá osztályt
- 5 tulajdonság
  - public get
  - private set
- 1 db konstruktor 
  - 1 paraméter --> string
  - pl.: "Berkenye;termés;9;10"
  - ; -vel vannak elválasztva
  - 4 db adat --> 5 tulajdonság?
  - átadott, fájlból beolvasott sort:
    - ';' mentén tagoljuk
    - beolvassuk
    - [0] --> Nev
    - [1] --> Resz
    - [2] --> Kezd
    - [3] --> Veg
    - Idotartam --> számolás (lásd alább)
- 5-dik tulajdonság --> időtartam
  - konstruktorban számoljuk
  - számolása: 
    - HA!! Vég > Kezdet --> Vég - Kezdet +1
    - Egyébként  --> 12 - Kezdet + Vég +1

## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be: 
  - System.IO
  - StreamReader 
  - while ciklussal --> amíg tart a file
  - cikluson belül listához hozzáadunk egy új objektum példányt (Beolvasott sor a paraméter)
 
## 1. Feladat
 - Hány növény van? (Lista.Count tulajdonság)
## 2. Feladat
 - Milyen gyűjthető részek vannak? 
 - Hány darab van ezekből?
 - Adatszerkezet: Dictionary<string, int>
 - 1. Milyen gyűjthető részek vannak?
      - Foreach a "Novenyek"-en
      - Ha a "Resz" nem kulcs  --> akkor adjuk hozzá 0-val
 - 2. Hány db van? 
      - Foreach a "Novenyek"-en
      - Ha a "Resz" == Key --> Value + 1
## 3. Feladat
 - Maximum keresés az időtartam alapján
   - maximum változó = 0
   - Foreach "Novenyek"
   - Ha max < "Idotartam" --> max = "Idotartam"
 - A növény(ek) amelyek a legtöbb ideig szedhetők
   - Foreach "Novenyek"
   - Kiírni ha Idotartam == max
## 4. Feladat
 - Időtartam átlag számítás (Összegzés tétele)
   - double szum változó = 0
   - atlag változó
   - Foreach "Novenyek"
   - szum = szum + Idotartam
   - atlag = szum / Count
