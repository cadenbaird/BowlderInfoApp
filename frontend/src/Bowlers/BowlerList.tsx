import { useEffect, useState } from 'react';
import { OneBowlerInfo } from '../types/oneBowlerInfo';

// Component for displaying a list of bowlers.
function BowlerList() {
  // State to hold the list of bowlers.
  const [bowlerData, setBowlerData] = useState<OneBowlerInfo[]>([]);
  useEffect(() => {
    // Fetches bowler data from the backend on component mount.
    const fetchBowlerData = async () => {
      try {
        const response = await fetch('https://localhost:7285/api/bowler');
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        const data = await response.json();
        console.log(data); // Log the data to inspect it
        setBowlerData(data); // Update state with fetched data
      } catch (error) {
        console.error('Error fetching bowler data:', error);
      }
    };

    fetchBowlerData();
  }, []); // Empty dependency array means this effect runs once on mount
  // Render the list of bowlers in a table.
  return (
    <>
      <div className="row">
        <h4 className="text-center">List of Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>BowlerID</th>
            <th>BowlerLastName</th>
            <th>BowlerFirstName</th>
            <th>BowlerMiddleInit</th>
            <th>BowlerAddress</th>
            <th>BowlerCity</th>
            <th>BowlerState</th>
            <th>BowlerZip</th>
            <th>BowlerPhoneNumber</th>
            <th>TeamID</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((data) => (
            <tr key={data.BowlerID}>
              <td>{data.BowlerID}</td>
              <td>{data.BowlerLastName}</td>
              <td>{data.BowlerFirstName}</td>
              <td>{data.BowlerMiddleInit}</td>
              <td>{data.BowlerAddress}</td>
              <td>{data.BowlerCity}</td>
              <td>{data.BowlerState}</td>
              <td>{data.BowlerZip}</td>
              <td>{data.BowlerPhoneNumber}</td>
              <td>{data.TeamID}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
export default BowlerList;
