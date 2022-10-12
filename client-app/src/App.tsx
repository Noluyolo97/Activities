import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from "axios";
import { Header } from 'semantic-ui-react';
import { ListFormat } from 'typescript';

function App() {
const [activities, setActivities] = useState([]);

//useEffect is called on every re-render
useEffect(() => {
axios.get('http://localhost:5000/api/activities').then(response => {
   console.log(response);
   setActivities(response.data);})
   // move on

.catch(e => {
  if (e.response.status === 404) {
    // whatever, nbd
  }
});

}, []);//<--- array of dependencies, to prevent the infinite call back

  return (
    <div>
      <Header as='h2' icon='users' content='Activities' />
    </div>
  );
}

export default App;
