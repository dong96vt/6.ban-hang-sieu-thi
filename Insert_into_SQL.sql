declare @i int
--Hàng hóa
set @i=0
while @i<=30
begin
set @i=@i+1
	INSERT INTO [dbo].[hanghoa]
           ([ma]
           ,[mahienthi]
           ,[ten]
           ,[soluongcon]
           ,[loaihang]
           ,[gia])
     VALUES
           ('HH'+CAST(@i as varchar)
           ,@i
           ,N'Hàng hóa '+CAST(@i as varchar)
           ,@i*10
           ,@i%4+1
           ,@i*10000)
end
-- Khách hàng
set @i=0
while @i<=10
begin
set @i=@i+1
	INSERT INTO [dbo].[khachhang]
           ([ma]
           ,[mahienthi]
           ,[hoten]
           ,[diachi]
           ,[gioitinh]
           ,[ngaysinh]
           ,[cmtnd]
           ,[sdt])
     VALUES
            ('KH'+CAST(@i as varchar)
           ,'KH'+CAST(@i as varchar)
           ,N'Khách hàng '+CAST(@i as varchar)
           ,CAST(@i as varchar)+ N' abc-xyz-Hà Nội'
           ,@i%2
           ,'1-1-0'
           ,CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)
           ,'09'+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar)+CAST(@i as varchar))
end
--Nhân viên
set @i=0
while @i<=10
begin
set @i=@i+1
	INSERT INTO [dbo].[nhanvien]
           ([ma]
           ,[mahienthi]
           ,[hoten]
           ,[quequan]
           ,[diachi]
           ,[gioitinh]
           ,[ngaysinh]
           ,[luong]
           ,[chucvu]
           ,[id]
           ,[pass])
     VALUES
           ('NV'+CAST(@i as varchar)
           ,'NV'+CAST(@i as varchar)
           ,N'Nhân viên '+CAST(@i as varchar)
           ,'Quê '+CAST(@i as varchar)
           ,'Địa chỉ'+CAST(@i as varchar)
           ,@i%2
           ,'1-1-1'
           ,@i*1000000
           ,N'Nhân viên'
           ,'NV'+CAST(@i as varchar)
           ,'NV'+CAST(@i as varchar))
end

INSERT INTO [dbo].[loaihanghoa]([ma],[ten])VALUES('0',N'Tất cả')
INSERT INTO [dbo].[loaihanghoa]([ma],[ten])VALUES('1',N'Đồ gia dụng')
INSERT INTO [dbo].[loaihanghoa]([ma],[ten])VALUES('2',N'Thực phẩm')
INSERT INTO [dbo].[loaihanghoa]([ma],[ten])VALUES('3',N'Đồ điện - điện tử')
INSERT INTO [dbo].[loaihanghoa]([ma],[ten])VALUES('4',N'Khác')
