create database DB_2k19_08_SieuTriTue
go
use DB_2k19_08_SieuTriTue


create table tinh(
	matinh int not null IDENTITY(1,1) primary key,
	tentinh nvarchar(50)
)

create table diadanh(
	madd int not null IDENTITY(1,1),
	tendd nvarchar(50),
	matinh int not null,
	constraint PK_ddtinh primary key(madd,matinh),
	foreign key (matinh) references tinh(matinh)
)

create table ngansach(
	mans int not null IDENTITY(1,1) primary key,
	kinhphi int,
	namcap int,
	matinh int foreign key references tinh(matinh)
)

create table hoatdong(
	mahd int not null IDENTITY(1,1) primary key,
	tenhd nvarchar(50),
	kinhphi int,
	ngaybd datetime,
	ngaykt datetime,
	mans int foreign key references ngansach(mans)
)
	
------Thêm dữ liệu mẫu-----------
	insert into tinh(tentinh) VALUES
		(N'Hà Nội'),
		(N'Hà Giang'),
		(N'Lào Cai'),
		(N'Đà Nẵng'),
		(N'Lâm Đồng');
--------Địa danh-----------
	insert into diadanh(tendd,matinh) VALUES
	(N'Hồ Hoàn Kiếm',1)
	,(N'Chùa Một Cột',1)
	,(N'Văn Miếu - Quốc Tử Giám',1)
	,(N'Tây Côn Lĩnh',2)
	,(N'Hồ Noong',2)
	,(N'Cao Nguyên Đá',2)
	,(N'Đỉnh Phan Xi Păng',3)
	,(N'Núi Hàm Rồng',3)
	,(N'Thác Bạc',3)
	,(N'Cầu Rồng',4)
	,(N'Mỹ Sơn',4)
	,(N'Núi Ngũ Hành Sơn',4)
	,(N'Hồ Tuyền Lâm',5)
	,(N'Langbiang',5)
	,(N'Chợ Đà Lạt',5);
-----------Ngân Sách---------
	insert into ngansach(kinhphi,namcap,matinh) values
		('10000',2018,1),
		('20000',2018,2),
		('50000',2018,3),
		('40000',2018,4),
		('50000',2018,5);
---------Hoạt Động-------------
	insert into hoatdong(tenhd,kinhphi,ngaybd,ngaykt,mans) values
		(N'Bắn Pháo Hoa','5000','1/1/2018','1/2/2018',1),
		(N'Festival Hoa','2000','5/10/2018','5/15/2018',2),
		(N'Đại Nhạc Hội','1000','2/1/2018','2/5/2018',3),
		(N'Bắn Pháo Hoa','4000','1/1/2018','1/2/2018',4);

-----------------------sp-------------------
-----------------Thêm,Xóa, Sửa Địa Danh------------------------------------
GO
	create procedure sp_addDiadanh @tendd nvarchar(50),@matinh int
	as
		insert into diadanh(tendd,matinh) values(@tendd,@matinh);
GO
	create procedure sp_delDiadanh @madd int
	as
		delete from diadanh where madd = @madd
GO
	create procedure sp_updateDiadanh @madd int,@tendd nvarchar(50),@matinh int
	as
		update diadanh set 
			tendd = @tendd,
			matinh = @matinh
		where @madd = madd

GO
	create procedure sp_getDiadanh @madd int = null
	as
		if (@madd is null)
			select diadanh.*,tinh.tentinh from diadanh
			JOIN tinh on tinh.matinh=diadanh.matinh
		else
			select diadanh.*,tinh.tentinh from diadanh
			JOIN tinh on tinh.matinh=diadanh.matinh
			where diadanh.madd = @madd;
			
-------------Cấp kinh Phí-----------------
GO
	create procedure sp_addNgansach @kinhphi int,@nam int,@matinh int
	as
		insert into ngansach(kinhphi,namcap,matinh) values(@kinhphi,@nam,@matinh)
GO
	create procedure sp_getNgansach @mans int = null
	as
		if (@mans is null)
			select ngansach.*,tinh.tentinh from ngansach
			JOIN tinh on tinh.matinh=ngansach.matinh;
		else
			select ngansach.*,tinh.tentinh from ngansach
			JOIN tinh on tinh.matinh=ngansach.matinh
			where mans=@mans;
 ---------------------------Thêm xóa sửa hoạt động-------------------
GO
create procedure sp_addHd @tenhd nvarchar(100),@kinhphi int,@ngaybd datetime, @ngaykt datetime,@mans int
	as
		DECLARE @flag INT = 0;
		select @flag=count(*) from ngansach where mans=@mans
		if(@flag>0)
			insert into hoatdong(tenhd,kinhphi,ngaybd,ngaykt,mans) values(@tenhd,@kinhphi,@ngaybd,@ngaykt,@mans);
		----------------------------------------------------------------
GO
	create procedure sp_delHd @mahd int
	as
		delete from hoatdong where mahd = @mahd
		------------------------------------------------------------------
GO
	create procedure sp_updateHd @mahd int,@tenhd nvarchar(50),@kinhphi int,@ngaybd datetime, @ngaykt datetime,@mans int
	as
		DECLARE @flag INT = 0;
		select @flag=count(*) from ngansach where mans=@mans
		if(@flag>0)
			update hoatdong set
				tenhd = @tenhd,
				kinhphi = @kinhphi,
				ngaybd =@ngaybd,
				ngaykt = @ngaykt,
				mans = @mans
			where @mahd = mahd

GO
	create procedure sp_getHd @mahd int = null
	as
		if(@mahd is null)
			Select hoatdong.*,tinh.tentinh from hoatdong
			JOIN ngansach on hoatdong.mans=ngansach.mans
			JOIN tinh on ngansach.matinh=tinh.matinh
		else
			Select hoatdong.*,tinh.tentinh from hoatdong
			JOIN ngansach on hoatdong.mans=ngansach.mans
			JOIN tinh on ngansach.matinh=tinh.matinh
			where mahd = @mahd

GO
	create procedure sp_getTinhthanh @matinh int = null
	as
		if(@matinh is null)
			Select * from tinh
		else
			Select * from tinh
			where matinh = @matinh

		