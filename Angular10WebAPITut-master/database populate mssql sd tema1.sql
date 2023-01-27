use CompanyDB

create table dbo.Userm(
UsermId int identity(1,1),
UsermName varchar(500),
UsermRole varchar(100)
);

select * from dbo.Department;
select * from dbo.Employee;

select * from dbo.Userm;

insert into dbo.Userm values('Tim','admin');
insert into dbo.Userm values('Timotei','user');
insert into dbo.Userm values('Ceai','user');
insert into dbo.Userm values('Geani','admin');
insert into dbo.Userm values('Cealoess','user');



create table dbo.Device(
DeviceId int identity(1,1),
UsermId int,
DeviceDescription varchar(500),
DeviceAddress varchar(500),
DeviceMaxHEnergyConsumption int
)

insert into dbo.Device values(0,'device1','cluj',300);
insert into dbo.Device values(0,'device2','ardeal',2020);
insert into dbo.Device values(0,'device3','sana',2026);
insert into dbo.Device values(0,'device4','mara',206);

select * from dbo.Device;

create table dbo.Mapping(
MappingId int identity(1,1),
UsermId int,
DeviceId int,
MappingTimestamp date,
MappingEnergyConsumption int
)