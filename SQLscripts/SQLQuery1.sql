USE [TASKMNGR_TEST2000]

INSERT [dbo].[Works] ([Id], [WorkName], [DueDate], [Description], [NextActionDate], [TypeWorkId], [StatusWorkId], [UserId1], [UserId], [CreatedOn], [ModifiedOn], [DeletedOn], [IsDeleted]) VALUES (N'cc4af617-06bd-48ce-926b-9f081a207b91', N'test', CAST(N'2022-02-11T00:00:00.0000000' AS DateTime2), N'NEW TASK!', NULL, 2, 3, NULL, N'79e7930c-3df5-4261-99cf-0352eb018a91', CAST(N'2022-02-11T17:52:51.5807054' AS DateTime2), NULL, NULL, 0)
GO
