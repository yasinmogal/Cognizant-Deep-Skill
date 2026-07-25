import { useState } from "react";

function StudentForm() {
  const [name, setName] = useState("");

  return (
    <div>
      <input
        type="text"
        placeholder="Enter Name"
        onChange={(e) => setName(e.target.value)}
      />

      <h3>{name}</h3>
    </div>
  );
}

export default StudentForm;