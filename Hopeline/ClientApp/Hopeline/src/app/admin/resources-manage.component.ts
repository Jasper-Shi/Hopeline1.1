import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AdminResCommService } from '../adminService/admin-res-comm.service';
import { ResCommServiceService } from '../resCommService/res-comm-service.service';
import { IResourceCategory } from '../interfaces/IResourceCategory';
import { IResource } from '../interfaces/IResource';

@Component({
  selector: 'app-resources-manage',
  templateUrl: './resources-manage.component.html',
  styleUrls: ['./resources-manage.component.css']
})
export class ResourcesManageComponent implements OnInit {
  resCateList: IResourceCategory[] = [];
  resCateListSub: any
  res: IResource;
  constructor(private _resCommService: ResCommServiceService, private _adminResCommService: AdminResCommService) { }

  ngOnInit() {
    this.resCateListSub = this._resCommService.getAllResourceCategories().subscribe((data) => {
      this.resCateList = data;
    });
    this.resInit();
  }
  uploadImg(event: any) {
    this.res.imageInput = event.target.files[0];
    console.log(this.res.imageInput);
  }
  setActive(event: any) {
    var et = event.target.checked;
    if (et) {
      this.res.enabled_flg = 1;
    }
    else {
      this.res.enabled_flg = 0;
    }
  }
  onSubmit(f: NgForm) {
    this._adminResCommService.addRes(this.res).subscribe(
      suc => {
        
      }
    )
  }

  resInit() {
    this.res = { id: 0, DateAdded: "", image: "", imageInput: null, user_code: "", title: "", desc: "", resource_CategoryId: null, resource_CategoryName: "", url: "", enabled_flg: 1 };
  }
}
