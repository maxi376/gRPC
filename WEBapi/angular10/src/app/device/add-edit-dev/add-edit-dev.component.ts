import { Component, OnInit ,Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-dev',
  templateUrl: './add-edit-dev.component.html',
  styleUrls: ['./add-edit-dev.component.css']
})
export class AddEditDevComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() dev:any;
  deviceId:string;
  usermId:string;
  deviceDescription:string;
  deviceAddress:string;
  deviceMaxHEnergyConsumption:string;

  UsermsList:any=[];

  ngOnInit(): void {
    this.deviceId=this.dev.deviceId;
    this.usermId=this.dev.usermId;
    this.deviceDescription=this.dev.deviceDescription;
    this.deviceAddress=this.dev.deviceAddress;
    this.deviceMaxHEnergyConsumption=this.dev.deviceMaxHEnergyConsumption;
  }

  loadUsermList(){
    this.service.getAllUsermNames().subscribe((data:any)=>{
      this.UsermsList=data;

      this.deviceId=this.dev.deviceId;
      this.usermId=this.dev.dsermId;
      this.deviceDescription=this.dev.deviceDescription;
      this.deviceAddress=this.dev.deviceAddress;
      this.deviceMaxHEnergyConsumption=this.dev.deviceMaxHEnergyConsumption;
    });
  }

  addDevice(){
    var val = {deviceId:this.deviceId,
              usermId:this.usermId,
              deviceDescription:this.deviceDescription,
              deviceAddress:this.deviceAddress,
              deviceMaxHEnergyConsumption:this.deviceMaxHEnergyConsumption};

    this.service.addDevice(val).subscribe(res=>{
      alert(res.toString());
    });
  }

  updateDevice(){
    var val = {deviceId:this.deviceId,
      usermId:this.usermId,
      deviceDescription:this.deviceDescription,
      deviceAddress:this.deviceAddress,
      deviceMaxHEnergyConsumption:this.deviceMaxHEnergyConsumption};

    this.service.updateDevice(val).subscribe(res=>{
    alert(res.toString());
    });
  }

}
