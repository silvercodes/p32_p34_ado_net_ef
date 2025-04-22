USE [p32_mystat_db]
GO
/****** Object:  Table [dbo].[branches]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branches](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](64) NULL,
	[city_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cities]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[classrooms]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[classrooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [nvarchar](32) NOT NULL,
	[title] [nvarchar](64) NULL,
	[branch_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pairs]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pairs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pair_date] [date] NOT NULL,
	[schedule_item_id] [int] NOT NULL,
	[subject_id] [int] NOT NULL,
	[is_online] [bit] NOT NULL,
	[classroom_id] [int] NULL,
	[teacher_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](128) NOT NULL,
	[slug] [varchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions_roles]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions_roles](
	[permission_id] [int] NOT NULL,
	[role_id] [int] NOT NULL,
 CONSTRAINT [PK_permissions_roles] PRIMARY KEY CLUSTERED 
(
	[permission_id] ASC,
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](128) NOT NULL,
	[slug] [varchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedule_items]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedule_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [tinyint] NOT NULL,
	[item_start] [time](7) NOT NULL,
	[item_end] [time](7) NOT NULL,
	[status] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subjects]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](256) NOT NULL,
	[deleted_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teachers]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teachers](
	[id] [int] NOT NULL,
	[first_name] [nvarchar](64) NOT NULL,
	[last_name] [nvarchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 22.04.2025 17:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](32) NOT NULL,
	[hash] [char](128) NOT NULL,
	[deleted_at] [datetime] NULL,
	[role_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[branches] ON 
GO
INSERT [dbo].[branches] ([id], [title], [city_id]) VALUES (1, N'branch_1', 1)
GO
SET IDENTITY_INSERT [dbo].[branches] OFF
GO
SET IDENTITY_INSERT [dbo].[cities] ON 
GO
INSERT [dbo].[cities] ([id], [title]) VALUES (1, N'city_1')
GO
SET IDENTITY_INSERT [dbo].[cities] OFF
GO
SET IDENTITY_INSERT [dbo].[classrooms] ON 
GO
INSERT [dbo].[classrooms] ([id], [number], [title], [branch_id]) VALUES (1, N'203', N'Robotics', 1)
GO
SET IDENTITY_INSERT [dbo].[classrooms] OFF
GO
SET IDENTITY_INSERT [dbo].[subjects] ON 
GO
INSERT [dbo].[subjects] ([id], [title], [deleted_at]) VALUES (1, N'EF Core', NULL)
GO
INSERT [dbo].[subjects] ([id], [title], [deleted_at]) VALUES (2, N'my_title', NULL)
GO
INSERT [dbo].[subjects] ([id], [title], [deleted_at]) VALUES (3, N'admin looser!', NULL)
GO
INSERT [dbo].[subjects] ([id], [title], [deleted_at]) VALUES (4, N'''my_title'');INSERT INTO subjects(title) VALUES(''admin looser!''', NULL)
GO
SET IDENTITY_INSERT [dbo].[subjects] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__permissi__32DD1E4C3CB2B1AB]    Script Date: 22.04.2025 17:21:11 ******/
ALTER TABLE [dbo].[permissions] ADD UNIQUE NONCLUSTERED 
(
	[slug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__roles__32DD1E4C339FB093]    Script Date: 22.04.2025 17:21:11 ******/
ALTER TABLE [dbo].[roles] ADD UNIQUE NONCLUSTERED 
(
	[slug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__AB6E6164B611C6F2]    Script Date: 22.04.2025 17:21:11 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[pairs] ADD  DEFAULT ((0)) FOR [is_online]
GO
ALTER TABLE [dbo].[schedule_items] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[branches]  WITH CHECK ADD  CONSTRAINT [FK_branches_city] FOREIGN KEY([city_id])
REFERENCES [dbo].[cities] ([id])
GO
ALTER TABLE [dbo].[branches] CHECK CONSTRAINT [FK_branches_city]
GO
ALTER TABLE [dbo].[classrooms]  WITH CHECK ADD  CONSTRAINT [FK_classrooms_branch] FOREIGN KEY([branch_id])
REFERENCES [dbo].[branches] ([id])
GO
ALTER TABLE [dbo].[classrooms] CHECK CONSTRAINT [FK_classrooms_branch]
GO
ALTER TABLE [dbo].[pairs]  WITH CHECK ADD  CONSTRAINT [FK_pairs_classroom] FOREIGN KEY([classroom_id])
REFERENCES [dbo].[classrooms] ([id])
GO
ALTER TABLE [dbo].[pairs] CHECK CONSTRAINT [FK_pairs_classroom]
GO
ALTER TABLE [dbo].[pairs]  WITH CHECK ADD  CONSTRAINT [FK_pairs_schedule_item] FOREIGN KEY([schedule_item_id])
REFERENCES [dbo].[schedule_items] ([id])
GO
ALTER TABLE [dbo].[pairs] CHECK CONSTRAINT [FK_pairs_schedule_item]
GO
ALTER TABLE [dbo].[pairs]  WITH CHECK ADD  CONSTRAINT [FK_pairs_subject] FOREIGN KEY([subject_id])
REFERENCES [dbo].[subjects] ([id])
GO
ALTER TABLE [dbo].[pairs] CHECK CONSTRAINT [FK_pairs_subject]
GO
ALTER TABLE [dbo].[pairs]  WITH CHECK ADD  CONSTRAINT [FK_pairs_teacher] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[teachers] ([id])
GO
ALTER TABLE [dbo].[pairs] CHECK CONSTRAINT [FK_pairs_teacher]
GO
ALTER TABLE [dbo].[permissions_roles]  WITH CHECK ADD  CONSTRAINT [FK_permissions_roles_permission] FOREIGN KEY([permission_id])
REFERENCES [dbo].[permissions] ([id])
GO
ALTER TABLE [dbo].[permissions_roles] CHECK CONSTRAINT [FK_permissions_roles_permission]
GO
ALTER TABLE [dbo].[permissions_roles]  WITH CHECK ADD  CONSTRAINT [FK_permissions_roles_role] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[permissions_roles] CHECK CONSTRAINT [FK_permissions_roles_role]
GO
ALTER TABLE [dbo].[teachers]  WITH CHECK ADD  CONSTRAINT [FK_teacher_user] FOREIGN KEY([id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[teachers] CHECK CONSTRAINT [FK_teacher_user]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_role] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_role]
GO
