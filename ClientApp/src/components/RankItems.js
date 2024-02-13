import React, { useEffect, useState } from "react";

const RankItems = () => {
  const [items, setItems] = useState([]);
  const dataType = 1;

  useEffect(() => {
    fetch(`item/${dataType}`)
      .then((res) => { return res.json() })
      .then(data => { setItems(data) })
  }, []);

  return (
    <main>
      {
        (items.length > 0)? items.map((item) => (<h3>{item.Name}</h3>)):<div><h4>Loading...</h4></div>
      }
    </main>
  )
}

export default RankItems;