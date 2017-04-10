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
           ,'Hàng hóa '+CAST(@i as varchar)
           ,@i*10
           ,null
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
           ,'Khách hàng '+CAST(@i as varchar)
           ,CAST(@i as varchar)+ ' abc-xyz-Hà Nội'
           ,@i%2
           ,null
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
           ,'Nhân viên '+CAST(@i as varchar)
           ,'Quê '+CAST(@i as varchar)
           ,'Địa chỉ'+CAST(@i as varchar)
           ,@i%2
           ,null
           ,@i*1000000
           ,'Nhân viên'
           ,'NV'+CAST(@i as varchar)
           ,'NV'+CAST(@i as varchar))
end
