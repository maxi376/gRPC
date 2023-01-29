import { Component, OnInit ,Input} from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-userms',
  templateUrl: './add-edit-userms.component.html',
  styleUrls: ['./add-edit-userms.component.css']
})
export class AddEditUsermsComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() userm:any;
  UsermId:string;
  UsermName:string;
  UsermRole:string;

  ngOnInit(): void {
    this.UsermId=this.userm.UsermId;
    this.UsermName=this.userm.UsermName;
    this.UsermRole=this.userm.UsermRole;
  }

  addUserm(){
    var val = {usermId:this.UsermId,
                usermName:this.UsermName,
                usermRole:this.UsermRole};

    this.service.addUserm(val).subscribe(res=>{
      alert(res.toString());
    });
  }

  updateUserm(){
    var val = {UsermId:this.UsermId,
      UsermName:this.UsermName,
      UsermRole:this.UsermRole};

    this.service.updateUserm(val).subscribe(res=>{
    alert(res.toString());
    });
  }

}
