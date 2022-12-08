Create database admin;
Use admin
go
create table employees1(
name nvarchar (255) not null,
phone_number nvarchar (15)not null primary key ,

password nvarchar(255) not null,

);
Select * from employees1
insert into employees1 (name,phone_number, password) 
values ('upasana','9843816723','nepal'),
('sova','9857687574','hello'),
('rinjha','9855647809','hi');