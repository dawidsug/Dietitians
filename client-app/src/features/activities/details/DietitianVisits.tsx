import React from 'react';
import { Button, Card, Image, Item } from 'semantic-ui-react';
import { Dietitian } from '../../../app/models/dietitian';
import { Visit } from '../../../app/models/visit';

interface Props{
    dietitian: Dietitian;
    cancelSelectDietitian: () => void;
    visits: Visit[];
    selectVisitor: () => void;
}
//this backtics in Image src to use code inside the string
export default function DietitianVisits({dietitian, visits, cancelSelectDietitian, selectVisitor}: Props){
    return(
        <Card fluid>
            <Image src={``} />
        <Card.Content>
            <Card.Header style={{display: 'flex', justifyContent:'center', marginBottom: '5px'}}>Appoitments to {dietitian.firstName} {dietitian.lastName}</Card.Header>
            <Card.Meta style={{display: 'flex', justifyContent:'center', marginBottom: '5px'}}>
                <span>Please choose one date.</span>
            </Card.Meta>
            <Card.Description>
                <Item.Group divided>
                    {visits.map(visit =>(
                        <Item key={visit.id}>
                            <Item.Content floated='center' marginBottom='5px' fontSize='10px'>
                                Date: {visit.date}
                            </Item.Content>
                            <Item.Content floated='left'>
                                <div>Name: {visit.name}</div>
                                <div>Description: {visit.description}</div>
                                <div>Type: {visit.type}</div>
                                <div>City: {visit.city}</div>
                                <div>Street: {visit.street} {visit.Number}</div>
                                <div>Street: {visit.postalCode}</div>
                            </Item.Content>
                            <Item.Content floated='right'>
                                <Button>Choose</Button>
                            </Item.Content>
                        </Item>
                        ))}
                </Item.Group>
            </Card.Description>
        </Card.Content>
        <Card.Content extra>
            <Button.Group widths='2'>
                <Button onClick={() => {cancelSelectDietitian(); selectVisitor();}} color='black' content='Cancel'/>
                <Button onClick={() => {cancelSelectDietitian(); selectVisitor();}} color='green' content='Confirm'/>
            </Button.Group>
        </Card.Content>
        </Card>
    )
}