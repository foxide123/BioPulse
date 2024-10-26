// Sidebar.js
import React from 'react';
import { Home, Power, HelpOutline, Water } from '@mui/icons-material';
import Avatar from '@mui/material/Avatar';
import { SidebarContainer, IconButton } from '../styles';

const Sidebar = () => (
    <SidebarContainer>
            <IconButton><Home /></IconButton>
            <IconButton><Power /></IconButton>
            <IconButton><HelpOutline /></IconButton>
            <IconButton><Water /></IconButton>
            <Avatar style={{ marginTop: 'auto' }} src="https://randomuser.me/api/portraits/men/32.jpg" />
    </SidebarContainer>
);

export default Sidebar;
