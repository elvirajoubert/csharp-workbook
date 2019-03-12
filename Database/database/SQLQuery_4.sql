create database M84;


go


use M84;

go

create table Toys1 (
    [id] [int] NOT NULL,
    [Price] decimal,
    [Aisle_id] int NULL,
    [Name] [varchar](150),
    [Quantity_in_stock] [varchar](150),
    [Description] [varchar](150),
    Primary Key (id)
);

GO


-- create table Aisle3(
--     id int NOT NULL,
--     name varchar (150)
--     Primary Key (id)
-- )

-- GO

insert into[dbo].[Aisle]
values(5, 'Five')

insert into [dbo].[Aisle]
values(10, 'Ten')

insert into [dbo].[Aisle]
values(15, 'Fifteen')

insert into [dbo].[Aisle]
values(20, 'Twenty')


GO


ALTER table Toys
add CONSTRAINT FOREIGNKey_ToyAisle
FOREIGN KEY(aisle_id) REFERENCES Aisle(id);

GO


insert into [dbo].[Toys]
Values(11, 4.99, 15, 'Captain America', 20, 'Action Figure')

insert into [dbo].[Toys]
Values(12, 0.99, 15, 'HotWheels', 60, 'Small car')

insert into[dbo].[Toys]
VALUES(1, 10.99, 5, 'Autobot', 100, 'Truck Toy')

insert into[dbo].[Toys]
VALUES(2, 11.99, 5, 'StarScream', 76, 'Truck Toy')

insert into[dbo].[Toys]
VALUES(3, 10.99, 5, 'BumbleBee', 24, 'Truck Toy')

insert into[dbo].[Toys]
VALUES(4, 8.99, 10, 'BattleBot', 45, 'Collapsable Truck')

insert into[dbo].[Toys]
VALUES(5, 9.99, 20, 'Flipazoo', 80, 'Plush Toy')

insert into[dbo].[Toys]
VALUES(6, 12.99, 15, 'TurboMan', 45, 'Action Figure')

insert into[dbo].[Toys]
VALUES(7, 14.99, 15, 'Batman', 67, 'Action Figure')

insert into[dbo].[Toys]
VALUES(8, 5.99, 15, 'Peter Porker', 89, 'Action Figure')

insert into[dbo].[Toys]
VALUES(9, 14.99, 15, 'SuperMan', 54, 'Action Figure')

insert into[dbo].[Toys]
VALUES(10, 15.99, 15, 'Thor', 100, 'Action Figure');

GO

Select name, description, aisle_id, quantity_in_stock
FROM [dbo].[Toys]
order by aisle_id;

GO

delete from Toys
where name IN ('Thor');


GO

SELECT name, description, aisle_id, quantity_in_stock
from [dbo].[Toys]
order by aisle_id;

update Toys
set quantity_in_stock = 113
where name = 'BumbleBee'


Select name, description, aisle_id, quantity_in_stock
FROM [dbo].[Toys]
order by name;




