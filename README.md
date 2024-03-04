
# .NET Core Backend Service Project README

Introduction
The .NET Core backend service project aims to develop a robust and scalable RESTful backend service using .NET Core (C#). Key features include integration with SQLite Server databases for efficient data management, JWT token-based authentication, and user role management using Identity Framework. Emphasis is placed on code organization, readability, and maintainability, with GitHub for version control and Microsoft Azure for deployment. 

## Project Description
This project focuses on building a robust .NET Core backend service with the following features:

- Utilization of SQLite Server database with at least 5 tables and foreign key relationships.
- Implementation of JWT token for secure user authentication.
- Integration of Identity Framework for user management, roles, and access control.
- Email service triggered upon user sign-up.
- Version control using GitHub repository.
- Deployment on Microsoft Azure for accessibility and scalability.

## Project Requirements
To meet the project's objectives, the following requirements are fulfilled:

- RESTful APIs for CRUD operations on relevant entities.
- User authentication using Identity Framework.
- Configuration of user roles (Admin, User, etc ) with distinct access permissions.
- Use of JWT tokens for authentication and authorization.
- Integration of an email service for user sign-up confirmation.
- Proper error handling and validation.
- Dependency Injection for efficient code organization.
- Logging implementation for tracking application events.

## Updated Code Organization
### Models and Controllers
- Models: All database models reside in the "Models" namespace/folder.
- Controllers: Organized within the "Controllers" namespace/folder.
- Authentication: Encapsulated within dedicated models and controllers.

## Updated Authentication and Authorization
### Identity Framework Implementation
- User authentication handled via Identity Framework.
- Role definition and permission assignment centralized.

### JWT Implementation
- JWT token logic encapsulated within specific models and controllers.

## Database Schema
- Well-structured relational database with organized model representations.


