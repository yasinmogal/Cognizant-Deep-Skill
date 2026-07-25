function StudentList() {
  const students = ["Yasin", "Rahul", "Amit"];

  return (
    <ul>
      {students.map((student, index) => (
        <li key={index}>{student}</li>
      ))}
    </ul>
  );
}

export default StudentList;