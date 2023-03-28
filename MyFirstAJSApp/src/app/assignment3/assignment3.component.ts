import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignment3',
  templateUrl: './assignment3.component.html',
  styleUrls: ['./assignment3.component.css']
})

export class Assignment3Component implements OnInit {

  showHide:boolean = true;
  
  clickCount:number = 0;
  logs = [];

  constructor() { }

  OnDisplayClick(){
    this.showHide = !this.showHide;
    this.clickCount +=1;
    this.logs.push(this.clickCount+1);
  }

  ngOnInit() {
  }

}
