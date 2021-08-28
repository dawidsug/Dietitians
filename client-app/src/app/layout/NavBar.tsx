import React from 'react';
import { Button, Container, Menu } from 'semantic-ui-react';

export default function NavBar() {
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src="/icon.png" alt="logo" style={{marginRight: '15px'}}/>
                    Dietitians
                </Menu.Item> 
                <Menu.Item name='Dietitians'/>
                <Menu.Item>
                    <Button positive content='Create Account' />
                </Menu.Item>
            </Container>
        </Menu>
    )
}