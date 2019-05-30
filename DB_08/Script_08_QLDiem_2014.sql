create database [DB_2k19_08_SieuTriTue]
go
use [DB_2k19_08_SieuTriTue]

---- Tao Table ----

create table doi(
	id_doi int not null IDENTITY(1,1) primary key,
	tendoi nvarchar(50)
);

create table thanhvien(
	id_tv int not null IDENTITY(1,1) primary key,
	id_doi int not null,
	ten nvarchar(50),
	ngaysinh date,
	constraint FK_thanhvien_doi	foreign key (id_doi) references doi(id_doi)
);

create table trandau(
	id_tran int not null IDENTITY(1,1) primary key,
	doiA int,
	doiB int,
	ngaydau date DEFAULT GETDATE(),
	constraint FK_TRANDAU_DOIA Foreign Key (doiA) References doi(id_doi),
	constraint FK_TRANDAU_DOIB Foreign Key (doiB) References doi(id_doi)
);

create table vongdau(
	id_vongdau int not null identity(1,1) primary key,
	id_tran int Foreign Key references trandau(id_tran),
	vong int,
	diem int,
	id_doithang int Foreign Key references doi(id_doi),
);

create table cauhoi(
	id_cauhoi int not null identity(1,1) primary key,
	id_vongdau int Foreign Key references vongdau(id_vongdau),
	noidung nvarchar(50),
	dapan bigint,
	diem int,
);
	
------Thêm dữ liệu mẫu-----------
set identity_insert doi on
insert into doi(id_doi,tendoi) VALUES
		(1,N'China'),
		(2,N'USA');
set identity_insert doi off
go

set identity_insert thanhvien on
insert into thanhvien(id_tv,id_doi,ten,ngaysinh) VALUES
	(1,1,N'Bruce Lee', '05/04/1995'),
	(2,1,N'Yang Lee', '01/03/1994'),
	(3,2,N'Taylor Swift', '05/04/1997'),
	(4,2,N'Eva', '02/04/1993');
set identity_insert thanhvien off
go

set identity_insert trandau on
insert into trandau(id_tran,doiA,doiB) VALUES
	(1,1,2);
set identity_insert trandau off
go

set identity_insert vongdau on
insert into vongdau(id_vongdau,id_tran,vong,diem,id_doithang) VALUES
	(1,1,1,50,2),
	(2,1,2,70,1);
set identity_insert vongdau off
go

set identity_insert cauhoi on
insert into cauhoi(id_cauhoi,id_vongdau,noidung,dapan,diem) VALUES
	(1,1,'300+600',900,20),
	(2,1,'3+6',9,10),
	(3,1,'50+60',110,10),
	(4,2,'30+60',90,20),
	(5,2,'33+66',99,10),
	(6,2,'5+6',11,10);
set identity_insert cauhoi off
go
-----------------------Store Procedure-------------------

-- Doi --

GO
	create procedure sp_addDoi @ten nvarchar(50)
	as
		insert into doi(tendoi) values(@ten);

GO
	create procedure sp_getdoi @id_doi int = null
	as
		if (@id_doi is null)
			select * from doi
		else
			select * from doi
			where id_doi = @id_doi;

-- Thanh Vien -- 

GO
	create procedure sp_addThanhVien @id_doi int,@ten nvarchar(50),@ngaysinh date
	as
		insert into thanhvien(id_doi,ten,ngaysinh) VALUES(@id_doi,@ten,@ngaysinh);

GO
	create procedure sp_getThanhVien @id_doi int = null
	as
		if (@id_doi is null)
			select * from thanhvien
		else
			select * from thanhvien
			where id_doi = @id_doi;
			
-- Tran Dau --
GO
	create procedure sp_addTranDau @doiA int, @doiB int
	as
		insert into trandau(doiA,doiB) values(@doiA,@doiB)

GO
	create procedure sp_getTranDau @id_tran int = null
	as
		if (@id_tran is null)
			Select * from trandau
		else
			Select * from trandau where id_tran=@id_tran

-- Vong Dau --
GO
	create procedure sp_addVongDau @id_tran int, @vong int, @diem int, @id_doithang int
	as
		insert into vongdau(id_tran,vong,diem,id_doithang) VALUES (@id_tran, @vong, @diem, @id_doithang);

GO
	create procedure sp_getVongDau @id_tran int = null
	as
		Select * from vongdau where id_tran=@id_tran

-- Cau hoi -- 

GO
	create procedure sp_addCauHoi @id_vongdau int, @noidung nvarchar(50), @dapan bigint, @diem int
	as
		insert into cauhoi(id_vongdau,noidung,dapan,diem) VALUES (@id_vongdau, @noidung, @dapan, @diem);

GO
	create procedure sp_getCauHoi @id_vongdau int = null
	as
		Select * from cauhoi where id_vongdau=@id_vongdau