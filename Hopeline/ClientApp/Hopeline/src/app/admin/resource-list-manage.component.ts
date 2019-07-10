import { Component, OnInit } from '@angular/core';
import { AdminResCommService } from '../adminService/admin-res-comm.service';
import { ResCommServiceService } from '../resCommService/res-comm-service.service';
import { IResource } from '../interfaces/IResource';
import { IResourceCategory } from '../interfaces/IResourceCategory';

@Component({
  selector: 'app-resource-list-manage',
  templateUrl: './resource-list-manage.component.html',
  styleUrls: ['./resource-list-manage.component.css']
})
export class ResourceListManageComponent implements OnInit {
  resList: IResource[] = [];
  filteredResList: IResource[] = [];
  resListSub: any;
  selectedRes: IResource;
  resCateList: IResourceCategory[] = [];
  resCateListSub: any;
  constructor(private _resCommService: ResCommServiceService, private _adminResCommService: AdminResCommService) { }

  ngOnInit() {
    this.resListSub = this._resCommService.getAllResources().subscribe((data) => {
      this.resList = data;
      this.filteredResList = [].concat(this.resList);
    });
    this.resCateListSub = this._resCommService.getAllResourceCategories().subscribe((data) => {
      this.resCateList = data;
    });
    this.selectResInit();
  }


  searchList(event: any) {
    var str = event.target.value.toLowerCase();
    if (str != '' && str != null) {
      this.filteredResList = this.filteredResList.filter(i => (i.user_code.toLowerCase().indexOf(str) !== -1) || (i.title.toLowerCase().indexOf(str) !== -1));
    }
    else {
      this.filteredResList = [].concat(this.resList);
    }
  }

  findDesc(id: number) {
    var tmp = this.filteredResList.find(i => i.id == id);
    this.selectedRes.id = tmp.id;
    this.selectedRes.DateAdded = tmp.DateAdded;
    this.selectedRes.user_code = tmp.user_code;
    this.selectedRes.resource_CategoryId = tmp.resource_CategoryId;
    this.selectedRes.desc = tmp.desc;
    this.selectedRes.enabled_flg = tmp.enabled_flg;
    this.selectedRes.image = tmp.image;
    this.selectedRes.title = tmp.title;
    this.selectedRes.url = tmp.url;
    this.matchResWithCate(this.selectedRes);
  }

  matchResWithCate(res: IResource) {
    res.resource_CategoryName = this.resCateList.find(i => i.id === res.resource_CategoryId).category_name;
  }

  enableRes(event: any, ress: IResource) {
    var res = event.target.checked;
    if (res) {
      this._adminResCommService.setResourceActive(ress, 1).subscribe(
        suc => {
          this.refreshList();
        }
      )
    }
    else {
      this._adminResCommService.setResourceActive(ress, 0).subscribe(
        suc => {
          this.refreshList();
        }
      )
    }
  }

  deleteRes(id: number) {
    var o = this.resList.find(i => i.id == id);
    this._adminResCommService.deleteRes(o).subscribe(
      suc => {
        this.refreshList();
      }
    )
  }

  refreshList() {
    this.resList = [];
    this.filteredResList = [];
    this.resListSub = this._resCommService.getAllResources().subscribe((data) => {
      this.resList = data;
      this.filteredResList = data;
    });
  }

  selectResInit() {
    this.selectedRes = {
      id: null, user_code: "", title: "", desc: "", image: "", url: "", DateAdded: "", resource_CategoryId: null, enabled_flg: null, resource_CategoryName:"", imageInput:null
    };
  }

}
