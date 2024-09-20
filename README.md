
Employee Verification API


Overview


This API facilitates employee verification processes, integrating frontend and backend functionalities. Built using ASP .NET Core Web API,
this solution provides a scalable and secure framework for employee data management.


Workflow


1. User submits verification request through frontend interface.
2. Backend API receives request, validates user data.
3. API queries database for employee information.
4. Verification result returned to frontend.


Technologies Used


- Backend: ASP .NET MVC Core Web API (.NET Core 3.1/5/6)
- Database: SQL Server (compatible with other relational databases)
- Programming Language: C# (backend), JavaScript (frontend)
- Frontend:  JavaScript


API Endpoints


- GET /api/VerifyEmploymentRequests - Retrieve all verification requests
- POST /api/VerifyEmploymentRequests - Create new verification request
- GET /api/VerifyEmploymentRequests/{id} - Retrieve request by ID
- PUT /api/VerifyEmploymentRequests/{id} - Update request
- DELETE /api/VerifyEmploymentRequests/{id} - Delete request


Challenges Faced


During testing, API performance issues arose due to low laptop configuration (RAM: [2 GB], Processor: [Core i3]). Optimizations implemented:


- Reduced API response payload size.



Future Improvements


- Enhance API security with authentication/authorization.
- Implement load balancing for high traffic.


Installation


1. Clone repository: git clone [repository URL]
2. Install dependencies: dotnet restore
3. Run application: dotnet run


Contributing


Contributions welcome! Fork repository, make changes, submit pull request.


License


Contact


Rudra Singh
rpsingh.developer@gmail.com
+91-9718728189


API Controller


VerifyEmploymentController.cs (included in repository)


Frontend JavaScript


Custom JavaScript code for frontend functionality (included in repository)


