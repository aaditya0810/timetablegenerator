USE [master]
GO
/****** Object:  Database [Time_Table]    Script Date: 12/29/2016 18:40:53 ******/
CREATE DATABASE [Time_Table] ON  PRIMARY 
( NAME = N'Time_Table', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Time_Table.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Time_Table_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Time_Table_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Time_Table] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Time_Table].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Time_Table] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Time_Table] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Time_Table] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Time_Table] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Time_Table] SET ARITHABORT OFF
GO
ALTER DATABASE [Time_Table] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Time_Table] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Time_Table] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Time_Table] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Time_Table] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Time_Table] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Time_Table] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Time_Table] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Time_Table] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Time_Table] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Time_Table] SET  DISABLE_BROKER
GO
ALTER DATABASE [Time_Table] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Time_Table] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Time_Table] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Time_Table] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Time_Table] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Time_Table] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Time_Table] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Time_Table] SET  READ_WRITE
GO
ALTER DATABASE [Time_Table] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Time_Table] SET  MULTI_USER
GO
ALTER DATABASE [Time_Table] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Time_Table] SET DB_CHAINING OFF
GO
USE [Time_Table]
GO
/****** Object:  Table [dbo].[TimeTableB]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TimeTableB](
	[slot] [varchar](50) NULL,
	[monday] [varchar](50) NULL,
	[tuesday] [varchar](50) NULL,
	[wednesday] [varchar](50) NULL,
	[thursday] [varchar](50) NULL,
	[friday] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TimeTableB] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'09:00-10:00', N'HTML-Hardik', N'C#-Sam', N'C++-Poonam', N'Java-Regina', N'HTML-Hardik')
INSERT [dbo].[TimeTableB] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'10:00-12:00', N'Practical G2-Hardik', N'Practical G4-Poonam', N'C#-Sam', N'HCI-Namita', N'C++-Poonam')
INSERT [dbo].[TimeTableB] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'12:00-12:30', N'Break', N'Break', N'Break', N'Break', N'Break')
INSERT [dbo].[TimeTableB] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'12:30-02:30', N'Practical G1-Regina', N'HCI-Namita', N'C++-Poonam', N'HCI-Namita', N'C#-Sam')
INSERT [dbo].[TimeTableB] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'02:30-02:45', N'Break', N'Break', N'Break', N'Break', N'Break')
INSERT [dbo].[TimeTableB] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'02:45-04:45', N'Practical G5-Samy', N'Java-Regina', N'HTML-Hardik', N'Java-Regina', N'HTML-Hardik')
/****** Object:  Table [dbo].[TimeTable]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TimeTable](
	[slot] [varchar](50) NOT NULL,
	[monday] [varchar](50) NULL,
	[tuesday] [varchar](50) NULL,
	[wednesday] [varchar](50) NULL,
	[thursday] [varchar](50) NULL,
	[friday] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TimeTable] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'09:00-10:00', N'C#-Samy', N'HTML-Poonam', N'Java-Sam', N'Soft Skill-Hardik', N'Java-Sam')
INSERT [dbo].[TimeTable] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'10:00-12:00', N'Practical G5-Samy', N'Practical G2-Hardik', N'Practical G1-Regina', N'C#-Samy', N'C#-Samy')
INSERT [dbo].[TimeTable] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'12:00-12:30', N'Break', N'Break', N'Break', N'Break', N'Break')
INSERT [dbo].[TimeTable] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'12:30-02:30', N'Soft Skill-Hardik', N'HCI-Regina', N'Java-Sam', N'HTML-Poonam', N'HTML-Poonam')
INSERT [dbo].[TimeTable] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'02:30-02:45', N'Break', N'Break', N'Break', N'Break', N'Break')
INSERT [dbo].[TimeTable] ([slot], [monday], [tuesday], [wednesday], [thursday], [friday]) VALUES (N'02:45-04:45', N'Practical G4-Poonam', N'Practical G3-Sam', N'HCI-Regina', N'Soft Skill-Hardik', N'HCI-Regina')
/****** Object:  Table [dbo].[TempB]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TempB](
	[cid] [varchar](50) NULL,
	[subject] [varchar](50) NULL,
	[teacher] [varchar](50) NULL,
	[type] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TempB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'C#', N'Sam', N'Lecture')
INSERT [dbo].[TempB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Java', N'Regina', N'Lecture')
INSERT [dbo].[TempB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'C++', N'Poonam', N'Lecture')
INSERT [dbo].[TempB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'HCI', N'Namita', N'Lecture')
INSERT [dbo].[TempB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Practical G3', N'Sam', N'Practical')
/****** Object:  Table [dbo].[Temp]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temp](
	[cid] [varchar](50) NULL,
	[subject] [varchar](50) NULL,
	[teacher] [varchar](50) NULL,
	[type] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Temp] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'C#', N'Samy', N'Lecture')
INSERT [dbo].[Temp] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'HCI', N'Regina', N'Lecture')
INSERT [dbo].[Temp] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Soft Skill', N'Hardik', N'Lecture')
INSERT [dbo].[Temp] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'HTML', N'Poonam', N'Lecture')
INSERT [dbo].[Temp] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Java', N'Sam', N'Lecture')
/****** Object:  Table [dbo].[teacher]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teacher](
	[tid] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[qualification] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[email] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[teacher] ([tid], [name], [qualification], [mobile], [email]) VALUES (N'50001', N'Regina', N'MCA', N'7045444454', N'samymary051@gmail.com')
INSERT [dbo].[teacher] ([tid], [name], [qualification], [mobile], [email]) VALUES (N'50010', N'Hardik', N'MCA', N'7123456789', N'hardik@gmail.com')
INSERT [dbo].[teacher] ([tid], [name], [qualification], [mobile], [email]) VALUES (N'50011', N'Sam', N'MCA', N'874561231', N'sam@gmail.com')
INSERT [dbo].[teacher] ([tid], [name], [qualification], [mobile], [email]) VALUES (N'50004', N'Poonam', N'MCA', N'71245454', N'poonam@gmail.com')
INSERT [dbo].[teacher] ([tid], [name], [qualification], [mobile], [email]) VALUES (N'50005', N'Samy', N'MCA', N'70215454', N'sam@gmail.com')
INSERT [dbo].[teacher] ([tid], [name], [qualification], [mobile], [email]) VALUES (N'50012', N'Namita', N'MCA', N'71245454', N'namita@gmail.com')
/****** Object:  Table [dbo].[final_tab]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[final_tab](
	[day] [varchar](50) NULL,
	[slot] [varchar](50) NULL,
	[subject] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[teacher] [varchar](50) NULL,
	[cid] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[courseB]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[courseB](
	[cid] [varchar](50) NULL,
	[subject] [varchar](50) NULL,
	[teacher] [varchar](50) NULL,
	[type] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Practical G1', N'Regina', N'Practical')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Practical G2', N'Hardik', N'Practical')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Practical G3', N'Sam', N'Practical')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Practical G4', N'Poonam', N'Practical')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Practical G5', N'Samy', N'Practical')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'Java', N'Regina', N'Lecture')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'HTML', N'Hardik', N'Lecture')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'C#', N'Sam', N'Lecture')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'C++', N'Poonam', N'Lecture')
INSERT [dbo].[courseB] ([cid], [subject], [teacher], [type]) VALUES (N'1002', N'HCI', N'Namita', N'Lecture')
/****** Object:  Table [dbo].[courseA]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[courseA](
	[cid] [varchar](50) NULL,
	[subject] [varchar](50) NULL,
	[teacher] [varchar](50) NULL,
	[type] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Practical G1', N'Regina', N'Practical')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Practical G2', N'Hardik', N'Practical')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Practical G3', N'Sam', N'Practical')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Practical G4', N'Poonam', N'Practical')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Practical G5', N'Samy', N'Practical')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'HCI', N'Regina', N'Lecture')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Soft Skill', N'Hardik', N'Lecture')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'Java', N'Sam', N'Lecture')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'HTML', N'Poonam', N'Lecture')
INSERT [dbo].[courseA] ([cid], [subject], [teacher], [type]) VALUES (N'1001', N'C#', N'Samy', N'Lecture')
/****** Object:  Table [dbo].[course]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[course](
	[cid] [varchar](50) NULL,
	[cname] [varchar](50) NULL,
	[lec] [varchar](50) NULL,
	[prac] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[course] ([cid], [cname], [lec], [prac]) VALUES (N'1001', N'MCA-A', N'5', N'5')
INSERT [dbo].[course] ([cid], [cname], [lec], [prac]) VALUES (N'1002', N'MCA-B', N'5', N'5')
/****** Object:  Table [dbo].[admin]    Script Date: 12/29/2016 18:40:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin](
	[id] [varchar](50) NULL,
	[pass] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[admin] ([id], [pass]) VALUES (N'admin', N'admin')
