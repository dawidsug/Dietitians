import React from 'react';
import { Button, Item, Segment } from 'semantic-ui-react';
import { Dietitian } from '../../../app/models/dietitian';

interface Props{
    selectedVisitor: Dietitian | undefined;
    selectEditedVisitor: () => void;
    cancelSelectVisitor: () => void;
}
//this backtics in Image src to use code inside the string
export default function VisitorDetails({selectedVisitor, selectEditedVisitor, cancelSelectVisitor}: Props){
    return(
        <Segment>
            <Item.Content>
                <Item.Header style={{display: 'flex', justifyContent:'center', marginBottom: '20px'}}>Hello {selectedVisitor?.firstName} {selectedVisitor?.lastName}</Item.Header>
                
                <Item.Content style={{display: 'flex', justifyContent:'left'}}>
                    <Item.Image size='small' src={`/assets/faceImages/${selectedVisitor?.firstName}.jpg`}/>
                    <Item.Content style={{marginLeft: '40px'}}>
                        <Item.Description>
                            <div>Description: {selectedVisitor?.description}</div>
                            <div>Phone number: {selectedVisitor?.phoneNumber}</div>
                            <div>Email: {selectedVisitor?.emailAddress}</div>
                        </Item.Description>
                    </Item.Content>
                    
                </Item.Content>
                <Item.Content style={{display: 'flex', justifyContent:'center', marginTop: '10px'}}>
                    <Button onClick={() => {selectEditedVisitor(); cancelSelectVisitor();}} color='black' content='Edit profile'/>
                </Item.Content>
            </Item.Content>
        </Segment>
        
    )
}