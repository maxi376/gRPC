import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private router:Router,private service:SharedService) { }
  username:string;
  password:string;
  adminOrUser:boolean;

  UsermList:any=[];
  userm:any;

  DeviceList:any=[];
  device:any;

  ngOnInit(): void {
  }

  loginFunction(pageName:string,pageName2:string):void{
    this.service.getUsermList().subscribe(data=>{
      this.service.UsermList=data;
    });
    this.adminOrUser=false;

    // this.service.UsermList.forEach( (element) => {
    //   this.username=element.UsermName;
    // });
    let list: string[] = [];

    // JSON.UserList.forEach(element => {
    //   list.push(element.Id);
    // });

    this.service.UsermList.forEach( (element) => {
      if ( this.password == "admin"){
        this.adminOrUser=true;
        this.router.navigate([`${pageName2}`]);
      }else if ( this.password == "user"){
        this.router.navigate([`${pageName}`]);

      }else
      {//this.router.navigate([`${pageName}`]);
    }

      /*if (element.UsermName == this.username && element.UsermRole == this.password){
        this.router.navigate([`${pageName}`]);
        // if (this.password=='user'){
        //   this.router.navigate([`${pageName}`]);
        // }else{
        //   pageName='admin';
        //   this.router.navigate([`${pageName}`]);
        // }
      }else{


      }*/
    });

    if (this.adminOrUser){

      this.router.navigate([`${pageName2}`]);
    }
  }

}
