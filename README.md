A many to many relationship happens when a record from table A is connected to multiple records from table B
and a record from table B is also connected to multiple records from table A
an example is the relation between Student_Table and Course_table
each student can enroll into 1 course or more 
and each course has 1 or more student in it
since this relation is impossible to implement using only 2 table we make a third join table
containing 2 forein keys from the 2 Tables and its own primary key
