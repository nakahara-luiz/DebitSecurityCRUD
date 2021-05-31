import { Debit } from "./debit";
import { Person } from "./person";

export class DebitSecurity {
  Debit!: Debit;
  Customer!: Person;
  DocumentNumber!: string;
  Id!: number;
}

export class DebitSecurityResume {
  DocumentNumber!: string;
  CustomerName!: string;
  NumberInstallments!: number;
  OriginalValue!: number;
  DaysOverDue!: number;
  ActualValue!: number;
}
