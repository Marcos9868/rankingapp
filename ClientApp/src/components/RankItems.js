import React, { useEffect, useState } from "react";
import MoviesList from "./MoviesImage";

const RankItems = () => {
  const [items, setItems] = useState([]);
  const dataType = 1;

  useEffect(() => {
    fetch(`item/${dataType}`)
      .then((res) => { 
        return res.json() 
      })
      .then(data => { 
        setItems(data) 
      })
  }, []);

  return (
    <main>
      <div className="items-not-ranked">
      {
        (MoviesList.length > 0)? MoviesList.map((item) => 
          <div className="unranked-cell">
            <img id={`item-${item.id}`} src={MoviesList.find(i => i.id === item.imageId)?.image} />
          </div>
        ) :
        <div>
          <h4>Loading...</h4>
        </div>
      }
      </div>
    </main>
  )
}

export default RankItems;