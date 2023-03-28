import {Component} from '@angular/core'

@Component({
    selector:'app-server',
    templateUrl:'./server.component.html',
    styles:[`
        .Online{
            color: white;
        }
    `]
})

export class ServerComponent{

    serverCreated = false;
    serverStatus = 'Offline';
    serverName='';

    constructor(){
        this.serverStatus= Math.random() > 0.5?'Online' : 'Offline';
    }

    getColor(){
        return this.serverStatus=='Online'?'green':'red';
    }

    OnServerCreate(){
        this.serverCreated = true;
    }

}