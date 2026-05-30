CREATE DATABASE IF NOT EXISTS hr_applicant_db;
USE hr_applicant_db;

CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL
);

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(100) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    RoleID INT NOT NULL,
    IsActive TINYINT(1) DEFAULT 1,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

CREATE TABLE ApplicantAccounts (
    ApplicantAccountID INT AUTO_INCREMENT PRIMARY KEY,
    Email VARCHAR(150) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    IsActive TINYINT(1) DEFAULT 1,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Applicants (
    ApplicantID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicantAccountID INT NOT NULL,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    MiddleName VARCHAR(100),
    DateOfBirth DATE,
    Gender VARCHAR(20),
    ContactNumber VARCHAR(20),
    Address TEXT,
    City VARCHAR(100),
    Province VARCHAR(100),
    FOREIGN KEY (ApplicantAccountID) REFERENCES ApplicantAccounts(ApplicantAccountID)
);

CREATE TABLE Departments (
    DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

CREATE TABLE JobVacancies (
    JobVacancyID INT AUTO_INCREMENT PRIMARY KEY,
    JobTitle VARCHAR(150) NOT NULL,
    DepartmentID INT,
    Description TEXT,
    Qualifications TEXT,
    EmploymentType VARCHAR(50),
    Status VARCHAR(20) DEFAULT 'Open',
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Applications (
    ApplicationID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicantID INT NOT NULL,
    JobVacancyID INT NOT NULL,
    Status VARCHAR(50) DEFAULT 'Draft',
    SubmittedAt DATETIME,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ApplicantID) REFERENCES Applicants(ApplicantID),
    FOREIGN KEY (JobVacancyID) REFERENCES JobVacancies(JobVacancyID)
);

CREATE TABLE RequirementTypes (
    RequirementTypeID INT AUTO_INCREMENT PRIMARY KEY,
    RequirementName VARCHAR(100) NOT NULL
);

CREATE TABLE ApplicantDocuments (
    DocumentID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT NOT NULL,
    RequirementTypeID INT NOT NULL,
    FilePath VARCHAR(255),
    Status VARCHAR(30) DEFAULT 'Missing',
    UploadedAt DATETIME,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (RequirementTypeID) REFERENCES RequirementTypes(RequirementTypeID)
);

CREATE TABLE ScreeningResults (
    ScreeningID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT NOT NULL,
    Result VARCHAR(20),
    Remarks TEXT,
    ScreenedBy INT,
    ScreenedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (ScreenedBy) REFERENCES Users(UserID)
);

CREATE TABLE InterviewSchedules (
    InterviewID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT NOT NULL,
    InterviewDate DATETIME,
    Mode VARCHAR(50),
    Location VARCHAR(150),
    InterviewerID INT,
    Status VARCHAR(30) DEFAULT 'Scheduled',
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (InterviewerID) REFERENCES Users(UserID)
);

CREATE TABLE InterviewEvaluations (
    EvaluationID INT AUTO_INCREMENT PRIMARY KEY,
    InterviewID INT NOT NULL,
    Score DECIMAL(5,2),
    Remarks TEXT,
    Result VARCHAR(20),
    EvaluatedBy INT,
    EvaluatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (InterviewID) REFERENCES InterviewSchedules(InterviewID),
    FOREIGN KEY (EvaluatedBy) REFERENCES Users(UserID)
);

CREATE TABLE HiringDecisions (
    DecisionID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT NOT NULL,
    Decision VARCHAR(20),
    Remarks TEXT,
    DecidedBy INT,
    DecidedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
    FOREIGN KEY (DecidedBy) REFERENCES Users(UserID)
);

CREATE TABLE ApplicationStatusHistory (
    HistoryID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicationID INT NOT NULL,
    Status VARCHAR(50) NOT NULL,
    Remarks TEXT,
    ChangedBy VARCHAR(100),
    ChangedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID)
);

CREATE TABLE AuditTrail (
    AuditID INT AUTO_INCREMENT PRIMARY KEY,
    UserType VARCHAR(30),
    UserID INT,
    Action VARCHAR(255),
    AffectedTable VARCHAR(100),
    AffectedID INT,
    ActionAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Seed Data
INSERT INTO Roles (RoleName) VALUES ('Admin'), ('HR Manager'), ('HR Staff');
INSERT INTO Departments (DepartmentName) VALUES ('Human Resources'), ('IT'), ('Finance'), ('Operations');
INSERT INTO RequirementTypes (RequirementName) VALUES ('Resume'), ('Valid ID'), ('Transcript of Records'), ('Certificate of Employment'), ('NBI Clearance');
INSERT INTO Users (Username, PasswordHash, RoleID) VALUES ('admin', 'admin123', 1), ('hrmanager', 'hr123', 2), ('hrstaff', 'staff123', 3);