import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { FormBuilder, FormGroup } from '@angular/forms';
import { DebitSecurityAPIService } from 'src/app/services/debit-security-api.service';
import { DebitSecurity, DebitSecurityResume } from 'src/app/models/document';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['debit-security-number', 'client-name', 'number-installments',
    'original-value', 'days-overdue', 'actual-value', 'action-edit'];

  filtersForm!: FormGroup;
  debitSecurities = new MatTableDataSource<DebitSecurityResume>();

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;

  constructor(
    private formBuilder: FormBuilder,
    private debitSecurityAPIService: DebitSecurityAPIService
  ) {}

  ngOnInit() {
    this.filtersForm = this.formBuilder.group({
      debitSecurityNumber: [''],
      clientName: ['']
    });

    this.debitSecurityAPIService.getDebits().subscribe(
      (data: DebitSecurity[]) => {
        if(data) {
          this.debitSecurities = new MatTableDataSource<DebitSecurityResume>();
        }

        console.log(this.debitSecurities);
      });
  }

  ngAfterViewInit() {
    this.debitSecurities.paginator = this.paginator;
  }

  edit(debitSecurityId: any) {

  }
}
