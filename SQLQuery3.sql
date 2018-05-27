SELECT AVG(student_marks.mark) AS VIDURKIS FROM student_marks
LEFT JOIN students on students.Id = student_marks.Id
ORDER BY VIDURKIS ASC