CREATE PROCEDURE GetTop20Students
AS
BEGIN
    -- Create a temporary table to hold the results
    CREATE TABLE #TopStudents (
		Rank INT,
        StudentId INT,
        StudentName VARCHAR(50),
        MathsMarks INT,
        EnglishMarks INT,
        PhysicsMarks INT,
        ScienceMarks INT,
        SocialMarks INT,
        TotalMarks INT
    )

    -- Insert data into the temporary table for top 20 students
    INSERT INTO #TopStudents (Rank,sd.StudentId, StudentName, MathsMarks, EnglishMarks, PhysicsMarks, ScienceMarks, SocialMarks, TotalMarks)
    SELECT ROW_NUMBER() OVER (ORDER BY (mathsMarks + PhysicsMarks + EnglishMarks + SocialMarks + ScienceMarks) DESC) AS Rank,
        sd.StudentId,
        sd.Name AS StudentName,
        m.MathsMarks,
        m.EnglishMarks,
        m.PhysicsMarks,
        m.ScienceMarks,
        m.SocialMarks,
        m.MathsMarks + m.EnglishMarks + m.PhysicsMarks + m.ScienceMarks + m.SocialMarks AS TotalMarks
    FROM
        student_details sd
        INNER JOIN marks m ON sd.StudentId = m.StudentId
     ORDER BY Rank,TotalMarks DESC
    OFFSET 0 ROWS
    FETCH NEXT 20 ROWS ONLY;

    -- Select the data from the temporary table
    SELECT * FROM #TopStudents

    -- Drop the temporary table
    DROP TABLE #TopStudents
END


drop procedure GetTop20Students;