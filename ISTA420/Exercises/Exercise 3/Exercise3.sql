select o.orderid, o.productid, o.unitprice, o.quantity, (o.unitprice * o.quantity) as total,
((o.unitprice * o.quantity) / (select sum(o2.unitprice * o2.quantity) as percent
from order_details o2 where o2.orderid = o.orderid) *100) as percent
from order_details o limit 10;

Output:

OrderID     ProductID   UnitPrice   Quantity    total       percent
----------  ----------  ----------  ----------  ----------  ----------------
10248       11          14.0        12          168.0       38.1818181818182
10248       42          9.8         10          98.0        22.2727272727273
10248       72          34.8        5           174.0       39.5454545454545
10249       14          18.6        9           167.4       8.98357840506601
10249       51          42.4        40          1696.0      91.016421594934
10250       41          7.7         10          77.0        4.24710424710425
10250       51          42.4        35          1484.0      81.8532818532819
10250       65          16.8        15          252.0       13.8996138996139
10251       22          16.8        6           100.8       15.0268336314848
10251       57          15.6        15          234.0       34.8837209302326
