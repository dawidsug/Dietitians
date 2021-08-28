import React from 'react';
import { Grid, GridColumn} from 'semantic-ui-react';
import { Dietitian } from '../../../app/models/dietitian';
import { Visit } from '../../../app/models/visit';
import DietitianVisits from '../details/DietitianVisits';
import VisitorForm from '../form/VisitorForm';
import DietitianList from './DietitianList';
import VisitorDetails from '../details/VisitorDetails';

interface Props{
    dietitians: Dietitian[];
    selectedDietitian: Dietitian | undefined;
    selectedVisitor: Dietitian | undefined;
    editedVisitor: Dietitian | undefined;
    selectDietitian: (id: string) => void;
    cancelSelectDietitian: () => void;
    selectVisitor: () => void;
    cancelSelectVisitor: () => void;
    selectToChange: (die: Dietitian) => void;
    selectEditedVisitor: () => void;
    cancelEditedVisitor: () => void;
    visits: Visit[];
}

export default function DietitianDashboard({dietitians, selectedDietitian, selectedVisitor, visits, editedVisitor, 
    selectDietitian, cancelSelectDietitian, selectVisitor, cancelSelectVisitor, selectToChange, selectEditedVisitor, cancelEditedVisitor}: Props) {
    return(
        <Grid>
            <GridColumn width='10'>
                <DietitianList dietitians={dietitians} selectDietitian={selectDietitian} selectToChange={selectToChange} cancelSelectVisitor={cancelSelectVisitor}/>
            </GridColumn>
            <GridColumn width='6'>
                {selectedDietitian &&
                <DietitianVisits dietitian={selectedDietitian} cancelSelectDietitian={cancelSelectDietitian} visits={visits} selectVisitor={selectVisitor}/>}
                {selectedVisitor &&
                <VisitorDetails selectedVisitor={selectedVisitor} selectEditedVisitor={selectEditedVisitor} cancelSelectVisitor={cancelSelectVisitor}/>}
                {editedVisitor &&
                <VisitorForm editedVisitor={editedVisitor} cancelEditedVisitor={cancelEditedVisitor} selectVisitor={selectVisitor}/>}
            </GridColumn>
        </Grid>
    )
}