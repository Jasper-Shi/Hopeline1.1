import { Component, OnInit } from '@angular/core';
import { ResCommServiceService } from '../resCommService/res-comm-service.service';
import { AdminResCommService } from '../adminService/admin-res-comm.service';
import { IResourceCategory } from '../interfaces/IResourceCategory';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-resource-category-manage',
  templateUrl: './resource-category-manage.component.html',
  styleUrls: ['./resource-category-manage.component.css']
})
export class ResourceCategoryManageComponent implements OnInit {
  resCatesList: IResourceCategory[] = [];
  filteredResCatesList: IResourceCategory[] = [];
  resCatesListSub: any;
  selectedResCate: IResourceCategory;
  delResCate: IResourceCategory;
  resCateAdd: IResourceCategory;
  constructor(private _resCommService: ResCommServiceService, private _adminResCommService:AdminResCommService) { }

  ngOnInit() {
    this.resCatesListSub = this._resCommService.getAllResourceCategories().subscribe((data) => {
      this.resCatesList = data;
      this.filteredResCatesList = data;
    });
    this.resCateAddInit();
    this.selectedResCateInit();
  }

  findDesc(id: number) {
    var tmp = this.filteredResCatesList.find(i => i.id == id);
    this.selectedResCate.id = tmp.id;
    this.selectedResCate.dateAdded = tmp.dateAdded;
    this.selectedResCate.user_code = tmp.user_code;
    this.selectedResCate.category_name = tmp.category_name;
    this.selectedResCate.category_decription = tmp.category_decription;
    this.selectedResCate.enable_flg = tmp.enable_flg;
  }

  searchList(event: any) {
    var substr = event.target.value.toLowerCase();
    if (substr == '' || substr == null) {
      this.filteredResCatesList = [].concat(this.resCatesList);
    }
    else {
      this.filteredResCatesList = this.filteredResCatesList.filter(i => ((i.category_name.toLowerCase().indexOf(substr) !== -1) || (i.user_code.toLowerCase().indexOf(substr) !== -1)));
    }
  }

  addResCate(f: NgForm) {
    this._adminResCommService.addResCate(this.resCateAdd).subscribe(
      suc => {
        this.refreshList();
        this.resCateAddInit();
      }
    )
  }

  editResCate() {
    console.log("edittt");
    this._adminResCommService.editResCate(this.selectedResCate).subscribe(
      suc => {
        this.refreshList();
      }
    );
  }

  deleteResCate(id: number) {
    this.delResCate = this.filteredResCatesList.find(i => i.id == id);
    this._adminResCommService.deleteResCate(this.delResCate).subscribe(
      suc => {
        this.refreshList();
        this.delResCate = null;
      }
    )
  }

  enableRc(event: any) {
    var res = event.target.checked;
    if (res) {
      this.resCateAdd.enable_flg = 1;
    }
    else {
      this.resCateAdd.enable_flg = 0;
    }
  }

  setFlg(event: any, rc: IResourceCategory) {
    var res = event.target.checked;
    if (res) {
      this._adminResCommService.setResCateFlg(rc, 1).subscribe(
        suc => {
          this.refreshList();
        }
      );
    }
    else {
      this._adminResCommService.setResCateFlg(rc, 0).subscribe(
        suc => {
          this.refreshList();
        }
      );
    }
  }

  discardDesc() {
    this.resCateAdd.category_decription = "";
  }

  resCateAddInit() {
    this.resCateAdd = {
      category_decription: "", category_name: "", user_code: "", id: null, dateAdded: "", enable_flg:1
    };
  }
  selectedResCateInit() {
    this.selectedResCate = {
      category_decription: "", category_name: "", user_code: "", id: null, dateAdded: "", enable_flg: 1
    };
  }

  refreshList() {
    this.resCatesList = [];
    this.filteredResCatesList = [];
    this.resCatesListSub = this._resCommService.getAllResourceCategories().subscribe((data) => {
      this.resCatesList = data;
      this.filteredResCatesList = data;
    });
  }

  ngOnDestroy() {
    //this.resCatesListSub.unsubscibe();
  }

}
