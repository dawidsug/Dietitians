import React from 'react';
import { Button, Form, Item, Segment } from 'semantic-ui-react';
import { Dietitian } from '../../../app/models/dietitian';

interface Props{
    editedVisitor: Dietitian | undefined;
    cancelEditedVisitor: () => void;
    selectVisitor: () => void;
}

export default function VisitorForm({editedVisitor, cancelEditedVisitor, selectVisitor}: Props){
    return(
        <Segment clearing>
            <Form>
            <Item style={{display: 'flex', justifyContent:'center', marginBottom: '5px'}}>Edit your profile</Item>
                <Form.Input placeholder='First Name'/>
                <Form.Input placeholder='Last Name'/>
                <Form.TextArea placeholder='Description'/>
                <Button onClick={() => {cancelEditedVisitor(); selectVisitor();}} floated='right' positive type='submit' content='Submit'/>
                <Button onClick={() => {cancelEditedVisitor(); selectVisitor();}} floated='right' type='button' content='Cancel'/>
            </Form>
        </Segment>
    )
}