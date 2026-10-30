# Student-Course API

A RESTful API built with **ASP.NET Core 8** and **Entity Framework Core** demonstrating a **many-to-many** relationship between students and courses. Built as a bootcamp homework assignment.

## The data model

A many-to-many relationship means a student can enroll in many courses, and each course can have many students. Since this can't be expressed with only two tables, a **join table** (`StudentCourse`) holds two foreign keys — one to `Student`, one to `Course`.

```
Student  1 ─── n  StudentCourse  n ─── 1  Course
```

## Stack

- ASP.NET Core 8 (Web API)
- Entity Framework Core 8 + SQL Server
- Swagger / OpenAPI (Swashbuckle)
- Docker setup for the database (`DockerDatabase/`)

## Endpoints

- `StudentController` — CRUD for students
- `CourseController` — CRUD for courses

## Running locally

```bash
dotnet restore
dotnet ef database update   # or start the DB via DockerDatabase/
dotnet run --project Student-Course
```
