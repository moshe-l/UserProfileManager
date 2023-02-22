/****** Object:  Table [dbo].[UsersProfile]    Script Date: 2/23/2023 12:07:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UsersProfile](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[image] [nvarchar](max) NULL,
	[dateOfBirth] [date] NULL,
 CONSTRAINT [PK_UsersProfile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


