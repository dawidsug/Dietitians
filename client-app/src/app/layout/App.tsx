import React, { Fragment, useEffect, useState } from 'react';
import axios from 'axios';
import { Container} from 'semantic-ui-react';
import { Dietitian } from '../models/dietitian';
import NavBar from './NavBar';
import DietitianDashboard from '../../features/activities/dashboard/DietitianDashboard';
import { Visit } from '../models/visit';

function App() {
  const [dietitians, setDietitians] = useState<Dietitian[]>([]);
  const [selectedDietitian, setSelectedDietitian] = useState<Dietitian | undefined>(undefined);
  const [selectedVisitor, setSelectedVisitor] = useState<Dietitian | undefined>();
  const [selectedToChange, changeLike] = useState<Dietitian| undefined>(undefined);
  const [visits, setVisits] = useState<Visit[]>([]);
  const [editedVisitor, setEditedVisitor] = useState<Dietitian | undefined>(undefined);


  useEffect(() => {
    axios.get<Dietitian[]>('http://localhost:5000/api/dietitians/getdietitians').then(response => {
    setDietitians(response.data);
    })
  }, [])

  useEffect(() => {
    axios.get<Visit[]>('http://localhost:5000/api/visits/getvisits').then(response => {
    setVisits(response.data);
    })
  }, [])

  function handleSelectDietitian(id: string){
    setSelectedDietitian(dietitians.find(x => x.id === id));
  }

  function handleCancelSelectDietitian(){
    setSelectedDietitian(undefined);
  }

  function handleSelectVisitor(){
    setSelectedVisitor(dietitians.find(x => x.firstName === 'Uncle'));
  }

  function handleCancelSelectVisitor(){
    setSelectedVisitor(undefined);
  }

  function handleSelectToChange(die: Dietitian){
    if(die !== undefined)
    {
      changeLike(die);
    }
  }

  function handleSelectEditedVisitor(){
    setEditedVisitor(dietitians.find(x => x.firstName === 'Uncle'));
  }

  function handleCancelEditedVisitor(){
    setEditedVisitor(undefined);
  }

  return (
    <Fragment>
      <NavBar />
      <Container style={{marginTop: '7em'}}>
        <DietitianDashboard 
        dietitians={dietitians}
        selectedDietitian={selectedDietitian}
        selectedVisitor={selectedVisitor}
        selectDietitian={handleSelectDietitian}
        cancelSelectDietitian={handleCancelSelectDietitian}
        selectVisitor={handleSelectVisitor}
        cancelSelectVisitor={handleCancelSelectVisitor}
        selectToChange={handleSelectToChange}
        visits={visits}
        editedVisitor={editedVisitor}
        selectEditedVisitor={handleSelectEditedVisitor}
        cancelEditedVisitor={handleCancelEditedVisitor}
        />
      </Container>
    </Fragment>
  );
}

export default App;
