import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-databinding',
  templateUrl: './databinding.component.html',
  styleUrls: ['./databinding.component.css']
})
export class DatabindingComponent implements OnInit {

  buttonEnabled:Boolean=false;
  ServerCreateStatus = 'Server is not created yet';
  InputText = 'Before Entering text';
  serverCreated = false;

  constructor() { 
    setTimeout(() => {this.buttonEnabled = true}, 3000);
  }

  OnClickEventClicked(){
    this.serverCreated = true;
    this.ServerCreateStatus = 'Server is created';
  }

  ngOnInit() {
  }

}
