import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent implements OnInit {

  serverCreateStatus = 'No Server is created!';
  serverName = 'Test Server';
  servers = ['Test Server 1','Test Server 2','Test Server 3'];
  serverCreated = false;

  constructor() { }

  OnServerCreated(){
    this.serverCreateStatus = 'A Server with name '+this.serverName + ' is created!';
    this.servers.push(this.serverName);
    this.serverCreated = true;
  }

  ngOnInit() {
  }

}
