import React from 'react';
import { Button, Icon, Item, Label, Segment } from 'semantic-ui-react';
import { Dietitian } from '../../../app/models/dietitian';

interface Props{
    dietitians: Dietitian[];
    selectDietitian: (id: string) => void;
    selectToChange: (die: Dietitian) => void;
    cancelSelectVisitor: () => void;
}


export default function DietitianList({dietitians, selectDietitian, selectToChange, cancelSelectVisitor}: Props){
    return(
        <Segment>
            <Item.Group divided>
                {dietitians.map(dietitian =>(
                    <Item key={dietitian.id}>
                        <Item.Content>
                            <Item.Header as='a' style={{display: 'flex', justifyContent:'center', marginBottom: '20px'}}>{dietitian.firstName} {dietitian.lastName}</Item.Header>
                            
                            <Item.Content style={{display: 'flex', justifyContent:'left'}}>
                                <Item.Image size='small' src={`/assets/faceImages/${dietitian.firstName}.jpg`}/>
                                <Item.Content style={{marginLeft: '40px'}}>
                                    <Item.Description>
                                        <div>Description: {dietitian.description}</div>
                                        <div>Phone number: {dietitian.phoneNumber}</div>
                                        <div>Email: {dietitian.emailAddress}</div>
                                    </Item.Description>
                                </Item.Content>
                                
                            </Item.Content>

                            
                            <Item.Extra>
                                <Button as='div' labelPosition='right'>
                                    <Button onClick={() => {dietitian.like+=1; selectToChange(dietitian);}}  icon color='olive'>
                                        <Icon name='heart'/>
                                        Like
                                    </Button>
                                    <Label as='a' basic pointing='left'>
                                        {dietitian.like}
                                    </Label>
                                </Button>
                                <Button as='div' labelPosition='left'>
                                <Label as='a' basic pointing='right'>
                                    {dietitian.unlike}
                                </Label>
                                <Button onClick={() => {dietitian.unlike+=1; selectToChange(dietitian);}} icon color='orange'>
                                    <Icon name='heart' />
                                    Unlike
                                </Button>
                                </Button>
                                <Button onClick={() => {selectDietitian(dietitian.id); cancelSelectVisitor();}} floated='right' content='Visits' color='blue'/>
                            </Item.Extra>
                        </Item.Content>

                    </Item>
                ))}
            </Item.Group>
        </Segment>
    )
}