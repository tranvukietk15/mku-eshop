Idea: Build dự án eshop Bán quần áo.
copy giống trang web: https://www.shein.com.vn/

Code First Migrations

1. Add Migrations:     dotnet ef migrations add "name" -c DbContext
2. Remove Migrations:  dotnet ef migrations remove
3. Update database:           dotnet ef databse update
4. Update revert database:    dotnet ef databse update Migration_Name