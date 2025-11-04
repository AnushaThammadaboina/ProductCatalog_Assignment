Project Name: Product Catalog (Angular + ASP.NET Core Web API + PBI Extension)

Setup Instructions
Clone or unzip the project into your local folder.
Open the .sln file in Visual Studio 2022.
Right-click Solution → Configure Startup Projects → Multiple startup projects
Set ProductCatalogs.Server → Start
Set productcatalogs.client → Start
Run backend first or press F5 to start both.
Backend URL → https://localhost:7291/swagger/index.html
If running separately:
cd productcatalogs.client
ng serve -o
Frontend URL → http://localhost:51734/

API Endpoints
Method	Endpoint	Description
GET	/api/Product/GetProducts	Get all products
GET	/api/Product/GetProduct/{id}	Get one product by ID
GET	/api/Product/GetProductAttributes/{id}	Get attributes of a product
GET	/api/Product/pbi	Simulated Power BI endpoint

Sample URLs
https://localhost:7291/api/Product/GetProducts
https://localhost:7291/api/Product/GetProduct/1
https://localhost:7291/api/Product/GetProductAttributes/1
https://localhost:7291/api/Product/pbi

Frontend Features
Displays all products in a styled table.
Clicking “View Attributes” shows product attributes.
Shows “No attributes available” when none exist.

Tech Stack
Backend: ASP.NET Core Web API (.NET 8)
Frontend: Angular 17
Languages: C#, TypeScript
Extras: CORS enabled, Swagger, PBI Simulation Endpoint

After pasting this, press Ctrl + S to save.