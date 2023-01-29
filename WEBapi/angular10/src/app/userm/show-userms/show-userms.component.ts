import { Component, OnInit,Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import {Userm} from 'src/app/models/userm.model';

@Component({
  selector: 'app-show-userms',
  templateUrl: './show-userms.component.html',
  styleUrls: ['./show-userms.component.css']
})
export class ShowUsermsComponent implements OnInit {

  constructor(private service:SharedService) { }

  ModalTitle:string;
  ActivateAddEditUsermComp:boolean=false;
  userm:any;

  UsermList:any=[];

  Userms: Userm[] = [];


  ngOnInit(): void {
    this.refreshUsermList();
  }

  addClick(){
    this.userm={
      UsermId:0,
      UsermName:"",
      UsermRole:""
    }
    this.ModalTitle="Add Userm";
    this.ActivateAddEditUsermComp=true;

  }

  editClick(item){
    this.userm=item;
    this.ModalTitle="Edit Userm";
    this.ActivateAddEditUsermComp=true;
  }

  closeClick(){
    this.ActivateAddEditUsermComp=false;
    this.refreshUsermList();
  }

  deleteClick(item){
    if(confirm('Are you sure??')){
      this.service.deleteUserm(item.UsermId).subscribe(data=>{
        alert(data.toString());
        this.refreshUsermList();
      })
    }
  }

  refreshUsermList(){
    this.service.getUsermList().subscribe(data=>{
      //this.UsermList=data;
      this.Userms=data;
      //this.UsermListWithoutFilter=data;
    });
  }

}
