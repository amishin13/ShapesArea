--use <DB_NAME>
--go

-- Create tables
if not exists (select * from information_schema.tables where table_name = 'product')
begin
	create table dbo.product (
		 id			int				not null
		,name		varchar(255)	not null
		,constraint pk_product primary key clustered (id)
	)

	insert into dbo.product (
		 id
		,name
	)
	values
		 (1, 'Колбаса')
		,(2, 'Мясо')
		,(3, 'Сок')
		,(4, 'Пиво')
		,(5, 'Хлеб')
end

if not exists (select * from information_schema.tables where table_name = 'category')
begin
	create table dbo.category (
		 id			int				not null
		,name		varchar(255)	not null
		,constraint pk_category primary key clustered (id)
	)

	insert into dbo.category (
		 id
		,name
	)
	values
		 (1, 'Напитки')
		,(2, 'Мясные изделия')
		,(3, 'Алкоголь')
		,(4, 'Бытовая химия')
end

if not exists (select * from information_schema.tables where table_name = 'product_category')
begin
	create table dbo.product_category (
		 id				int		identity(1,1)	not null
		,product_id		int						not null
			constraint fk_product_category_product_id foreign key
				references dbo.product(id)
		,category_id		int					not null
			constraint fk_product_category_category_id foreign key
				references dbo.category(id)
		,constraint pk_product_category primary key nonclustered (id)
	)

	create unique clustered index ix_product_category_product_id_category_id
		on dbo.product_category(product_id, category_id)

	insert into dbo.product_category (
		 product_id
		,category_id
	)
	values
		 (1, 2)
		,(2, 2)
		,(3, 1)
		,(4, 1)
		,(4, 3)
end

-- Query
select
	P.name + isnull(' - ' + C.name, '')	as product_with_category
from
	dbo.product P
	left join dbo.product_category PC
		inner join dbo.category C
			on C.id = PC.category_id
		on PC.product_id = P.id

-- Drop tables
drop table if exists dbo.product_category
drop table if exists dbo.product
drop table if exists dbo.category
go
