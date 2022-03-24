CREATE TABLE [BlogPost] (
    [PostId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [ShortDescription] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_BlogPost] PRIMARY KEY ([PostId])
);