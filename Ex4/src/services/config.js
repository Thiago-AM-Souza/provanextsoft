import axios from 'axios';

export const http = axios.create({
    baseURL: 'http://provanextsoft.somee.com/api/'
    //baseURL: 'https://localhost:44330/api/'
});