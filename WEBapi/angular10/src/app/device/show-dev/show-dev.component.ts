import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-show-dev',
  templateUrl: './show-dev.component.html',
  styleUrls: ['./show-dev.component.css']
})
export class ShowDevComponent implements OnInit {

  constructor(private service:SharedService) { }

  ModalTitle:string;
  ActivateAddEditDevComp:boolean=false;
  dev:any;

  DeviceList:any=[];

  ngOnInit(): void {
    this.refreshDevList();
  }

  addClick(){
    this.dev={
      DeviceId:0,
      UsermId:0,
      DeviceDescription:"",
      DeviceAddress:"",
      DeviceMaxHEnergyConsumption:0
    }
    this.ModalTitle="Add Device";
    this.ActivateAddEditDevComp=true;

  }

  editClick(item){
    this.dev=item;
    this.ModalTitle="Edit Device";
    this.ActivateAddEditDevComp=true;
  }

  closeClick(){
    this.ActivateAddEditDevComp=false;
    this.refreshDevList();
  }

  deleteClick(item){
    if(confirm('Are you sure??')){
      this.service.deleteDevice(item.deviceId).subscribe(data=>{
        alert(data.toString());
        this.refreshDevList();
      })
    }
  }

  refreshDevList(){
    this.service.getDevList().subscribe(data=>{
      this.DeviceList=data;
      //this.DeviceListWithoutFilter=data;
    });
  }

}
