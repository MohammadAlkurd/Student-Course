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
- Docker Compose for the database (`Student-Course/DockerDatabase/docker-compose.yml`)

## Endpoints

Base route: `api/<controller>`.

| Method | Route | Parameters | Description |
|--------|-------|------------|-------------|
| GET    | `/api/Student` | — | List all students |
| POST   | `/api/Student` | `?name=` | Create a student |
| GET    | `/api/Course` | — | List all courses |
| POST   | `/api/Course` | `?name=` | Create a course |

## Database setup

Start SQL Server with the included compose file:

```bash
docker compose -f Student-Course/DockerDatabase/docker-compose.yml up -d
```

The connection string in `Student-Course/Program.cs` already points at that container (`localhost,1433`, database `University`). Apply the migrations:

```bash
dotnet ef database update --project Student-Course
```

## Running locally

```bash
dotnet restore
dotnet run --project Student-Course
```

Swagger UI is available at `/swagger` in Development.

## License

MIT — see [LICENSE](LICENSE).
