import React from 'react';
import { Home, Power, HelpOutline, Water } from '@mui/icons-material';
import styled from 'styled-components';
import Avatar from '@mui/material/Avatar';

const SidebarContainer = styled.div`
    background-color: #edf5f7;
    padding: 20px;
    display: flex;
    flex-direction: column;
    align-items: center;
    height: 100%;
`;

const IconButton = styled.div`
    margin: 20px 0;
    display: flex;
    justify-content: center;
    align-items: center;
    width: 60px;  // Updated size
    height: 60px;
    background-color: white;
    border-radius: 15px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);  
    cursor: pointer;
    transition: background-color 0.3s ease;

    &:hover {
        background-color: #e0f7fa;
    }
`;


const Sidebar = () => {
    return (
        <SidebarContainer>
            <IconButton>
                <Home />
            </IconButton>
            <IconButton>
                <Power />
            </IconButton>
            <IconButton>
                <HelpOutline />
            </IconButton>
            <IconButton>
                <Water />
            </IconButton>
            <Avatar
                style={{ marginTop: 'auto' }}
                src="https://randomuser.me/api/portraits/men/32.jpg"
            />
        </SidebarContainer>
    );
};

export default Sidebar;
