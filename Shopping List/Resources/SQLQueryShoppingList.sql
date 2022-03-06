create database shopping
use shopping

create table Items
(
Item_Id int primary key identity(1,1),
Item_Name varchar(50),
Item_Quantity int,
Item_Importance varchar(50)
)

select * from Items
