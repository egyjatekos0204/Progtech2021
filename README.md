# Progtech beadandó

### Projekt
Én egy szendvics tároló alkalmazást szerettem volna megvalósítani. A lényege az, hogy vannak bizonyos szendvics alapok, mint például hogy nutellával vagy vajjal kenjük meg a kenyeret, emellett vannak még feltétek(addonok), amiket a szendvicsre pluszban rá tudunk rakni.

## Tervezési minták
### MVC modell
A program három részre lett felosztva. Modell, View, Controller. Ennek a hármas felosztásnak a célja az, hogy a program egyes részeit külön külön elkülönítve tudjuk tárolni.
### Modellek
* Sandwich(Bread:string, Base:string, Cost:double)
* Addons feltétekkel(Bread:string, Base:string, Cost:double) Decorator tervezési mintát implementál
* Storage(store, remove, add, get) Singleton osztály

### Nézetek
A projekt konzol applikációt valósít meg, ezért a view minden függvénye egy string-el tér vissza, ami tartalmazza az egyes opciókat.
* **Prompt**: tartalmazza az egyes opciókat, amiket a controller fog kiírni a képernyőre.

### Kontroller
* Storage Controller
 * handleUser()
 * addSandwich()
 * fillStorage()
 * setPrice()
 * getSandwichCount()
 * getSandwichByIndex()


### Singleton osztály
Lényege az hogy egyetlen példány lehet csak belőle, és így az osztály nevén keresztül közvetlen elérhető. Nem kell példányosítani ahhoz hogy elérjük egy mezőjét. A projektemben a Storage nevű osztályt elláttam a static kulcsszóval így az minden példányban ugyan azt a Storage-ot valósítja meg. Vannak helyzetek amikor a singleton osztálynak vannak előnyei de gyakran ütközhetünk nehézségekbe is.

### Decorator
Decorator osztály lényege az hogy egy kis kiegészítést ad hozzá a meglévő osztályunkhoz. Mikor különböző felépítés lehetséges, akkor nem célunk az hogy minden lehetséges esetre létrehozzunk egy újabb osztályt, hanem kiegészítő osztályokkal burkoljuk be azt. Az én esetemben a szendvicsekre kérhetőek különböző feltétek, nem szerettem volna minden szendvics típusra minden feltéttel külön osztályt írni, hanem írtam egy decorátort amivel becsomagolom az adott osztályt a szükséges tulajdonságokkal.

### Observer
Az obszervernek fog jelezni a subject hogy az egyik tulajdonsága megváltozott, megváltoztatja a többi alanynál is ezt a tulajdonságot. Például ha a fehér kenyér ára megváltozott az egyik szendvicsnél akkor a subject szól az observernek és ezáltal az observer megváltoztatja a többi fehér kenyérrel ellátott szendvics árát.


### Factory
A factory minta célja az hogy az egyes példányosítások rendezetten történjenek. Rendezettség alatt azt értjük hogy ne kelljen az egész kódban minden refaktorálnunk hanem egy adott kódblokkban ha új paraméterekkel kell felruháznunk a konstruktort akkor egy helyen ezt megtudjuk tenni. Az én esetemben ez a szendvicsek készítésénél volt hasznos.

## Unit test

* Szendvics storage feltöltése
    * megjelennek e a szendvicsek

* Szendvics törlése a storage-ból
    * kitörlődik-e a szendvics
