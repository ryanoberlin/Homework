#1.) The regions are: Eastern, Western, Norther, Southern

##Commands used:
*.tables
select * from region;
select regiondescription from region;*

#2.) The Cities:
Westboro Bedford Georgetow Boston Cambridge Braintree Providence Hollis Portsmouth Wilton Morristown Edison NewYork NewYork Mellvile 
Fairport Philadelphia Neward Rockville Greensboro Cary Columbia Atlanta Savannah Orlando Tampa Louisville Beachwood Findlay Southfield 
Troy BloomfieldHills Racine Roseville Minneapolis HoffmanEstates Chicago Bentonville Dallas Austin Denver ColoradoSprings Phoenix Scottsdale 
SantaMonica MenloPark SanFrancisco Campbell SantaClara SantaCruz Bellevue Redmond Seattle

##Commands used:
*.schema territories 
select TerritoryDescription from territories;*

#3.)Southern Region Cities are

Atlanta
Austin
Bentonville
Columbia
Dallas
Orlando
Savannah
Tampa

##Commands used:
*select territorydescription, regionid from territories where regionid = 4 order by territorydescription;*

#4.)
The following command will query with the fully qualified column name:
*select territories.territorydescription from territories where territories.regionid = 4;*

#5.)
*To create an alias for the previous command you would input it as follows:
select t.territorydescription from territories as t where t.regionid = 4;*

#6.) The contact name and phone number for each customer is:
Name | Number | City |
|:----|:----:|----:|
Sven Ottlieb|0241-039123|Aachen
Paula Wilson|(505) 555-5939|Albuquerque
Rene Phillips|(907) 555-7584|Anchorage
Eduardo Saavedra|(93) 203 4560|Barcelona
Carlos González|(9) 331-6954|Barquisimeto
Giovanni Rovelli|035-640230|Bergamo
Maria Anders|030-0074321|Berlin
Yang Wang|0452-076545|Bern
Jose Pavarotti|(208) 555-8097|Boise
Philip Cramer|0555-09876|Brandenburg
Catherine Dewey|(02) 201 24 67|Bruxelles
Maria Larsson|0695-34 67 21|Bräcke
Patricio Simpson|(1) 135-5555|Buenos Aires
Yvonne Moncada|(1) 135-5333|Buenos Aires
Sergio Gutiérrez|(1) 123-5555|Buenos Aires
Liu Wong|(406) 555-5834|Butte
André Fonseca|(11) 555-9482|Campinas
Manuel Pereira|(2) 283-2951|Caracas
Pascale Cartrain|(071) 23 67 22 20|Charleroi
ContactName|Phone|City
Patricia McKenna|2967 542|Cork
Helen Bennett|(198) 555-8888|Cowes
Horst Kloss|0372-035188|Cunewalde
Yoshi Latimer|(503) 555-6874|Elgin
Howard Snyder|(503) 555-7555|Eugene
Renate Messner|069-0245984|Frankfurt a.M.
Michael Holz|0897-034214|Genève
Roland Mendel|7675-3425|Graz
Matti Karttunen|90-224 8858|Helsinki
Felipe Izquierdo|(8) 34-56-12|I. de Margarita
Helvetius Nagy|(206) 555-8257|Kirkland
Jytte Petersen|31 12 34 56|Kobenhavn
Henriette Pfalzheim|0221-0644327|Köln
Art Braunschweiger|(307) 555-4680|Lander
Alexander Feuer|0342-023176|Leipzig
Martine Rancé|20.16.10.16|Lille
Lino Rodriguez|(1) 354-2534|Lisboa
Isabel de Castro|(1) 356-5634|Lisboa
Thomas Hardy|(171) 555-7788|London
Victoria Ashworth|(171) 555-1212|London
Elizabeth Brown|(171) 555-2282|London
Ann Devon|(171) 555-0297|London
Simon Crowther|(171) 555-7733|London
Hari Kumar|(171) 555-1717|London
Christina Berglund|0921-12 34 65|Luleå
Mary Saveley|78.32.54.86|Lyon
Martín Sommer|(91) 555 22 82|Madrid
Diego Roel|(91) 555 94 44|Madrid
Alejandra Camino|(91) 745 6200|Madrid
Hanna Moos|0621-08460|Mannheim
Laurence Lebihan|91.24.45.40|Marseille
Jean Fresnière|(514) 555-8054|Montréal
Ana Trujillo|(5) 555-4729|México D.F.
Antonio Moreno|(5) 555-3932|México D.F.
Francisco Chang|(5) 555-3392|México D.F.
Guillermo Fernández|(5) 552-3745|México D.F.
Miguel Angel Paolino|(5) 555-2933|México D.F.
Peter Franken|089-0877310|München
Karin Josephs|0251-031259|Münster
Janine Labrune|40.67.88.88|Nantes
Carine Schmitt|40.32.21.21|Nantes
Pirkko Koskitalo|981-443655|Oulu
Marie Bertrand|(1) 42.34.22.66|Paris
Dominique Perrier|(1) 47.55.60.10|Paris
Fran Wilson|(503) 555-9573|Portland
Liz Nixon|(503) 555-3612|Portland
Maurizio Moroni|0522-556721|Reggio Emilia
Paul Henriot|26.47.15.10|Reims
Paula Parente|(14) 555-8122|Resende
Mario Pontes|(21) 555-0091|Rio de Janeiro
Bernardo Batista|(21) 555-4252|Rio de Janeiro
Janete Limeira|(21) 555-3412|Rio de Janeiro
Georg Pipps|6562-9722|Salzburg
Carlos Hernández|(5) 555-1340|San Cristóbal
Jaime Yorres|(415) 555-5938|San Francisco
Pedro Afonso|(11) 555-7647|Sao Paulo
Aria Cruz|(11) 555-9857|Sao Paulo
Lúcia Carvalho|(11) 555-1189|Sao Paulo
Anabela Domingues|(11) 555-2167|Sao Paulo
Karl Jablonski|(206) 555-4112|Seattle
José Pedro Freyre|(95) 555 82 82|Sevilla
Jonas Bergulfsen|07-98 92 35|Stavern
Frédérique Citeaux|88.60.15.31|Strasbourg
Rita Müller|0711-020361|Stuttgart
Paolo Accorti|011-4988260|Torino
Annette Roulet|61.77.61.10|Toulouse
Elizabeth Lincoln|(604) 555-4729|Tsawassen
Yoshi Tannamuri|(604) 555-3392|Vancouver
Daniel Tonini|30.59.84.10|Versailles
John Steel|(509) 555-7969|Walla Walla
Zbyszek Piestrzeniewicz|(26) 642-7012|Warszawa
Palle Ibsen|86 21 32 43|Århus

##Commands used:
~.schema customers;
~select ContactName, Phone, City from customers order by City;

#7.) Products out of stock
On Hand | Name|
----|-----|
0|Chef Anton's Gumbo Mix
0|Alice Mutton
0|Thüringer Rostbratwurst
0|Gorgonzola Telino
0|Perth Pasties

##Commands used:
*.schema products
select UnitsInStock, ProductName from products where UnitsInStock = 0;*

#The products with the least amount on hand are:
On hand | Name |
-------|-----|
3|Sir Rodney's Scones
4|Louisiana Hot Spiced Okra
4|Longlife Tofu
5|Rogede sild
6|Northwoods Cranberry Sauce
6|Scottish Longbreads
9|Mascarpone Fabioli
10|Nord-Ost Matjeshering
10|Maxilaku
11|Gravad lax

##Commands Used:
*select UnitsInStock, ProductName from products where UnitsInStock order by UnitsInStock asc limit 10;*

#9.)The five most Expensive products:
|price|Item|
------|----|
263.5|Côte de Blaye
123.79|Thüringer Rostbratwurst
97.0|Mishi Kobe Niku
81.0|Sir Rodney's Marmalade
62.5|Carnarvon Tigers

##Commands used:
*select UnitPrice, ProductName from products order by UnitPrice desc limit 5;*

#10.)Total prducts, customers, and suppliers is:
Count|Group|
----|-----|
77 Products
92 Customers
29 Supliers

##Commands used:
*select COUNT(*) from products;
select COUNT(*) from customers;
select COUNT(*) from suppliers;*



